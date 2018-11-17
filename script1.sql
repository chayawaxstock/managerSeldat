

CREATE DATABASE `ManagerTasks`

USE `ManagerTasks`
-- ************************************** `Department`

CREATE TABLE `Department`
(
 `id`         int NOT NULL AUTO_INCREMENT ,
 `department` nvarchar(15) NOT NULL ,

PRIMARY KEY (`id`)
);






-- ************************************** `User`

CREATE TABLE `User`
(
 `id`               int NOT NULL AUTO_INCREMENT ,
 `userName`         nvarchar(20) NOT NULL ,
 `userComputer`     nvarchar(20) ,
 `password`         nvarchar(64) NOT NULL ,
 `departmentUserId` int NOT NULL ,
 `email`            nvarchar(20) NOT NULL ,
 `numHourWork`      decimal NOT NULL COMMENT 'num hour that worker work' CHECK (numHourWork>=2 AND numHourWork<12) ,
 `managerId`        int ,

PRIMARY KEY (`id`),
KEY `fkIdx_133` (`departmentUserId`),
CONSTRAINT `FK_133` FOREIGN KEY `fkIdx_133` (`departmentUserId`) REFERENCES `Department` (`id`),
KEY `fkIdx_182` (`managerId`),
CONSTRAINT `FK_182` FOREIGN KEY `fkIdx_182` (`managerId`) REFERENCES `User` (`id`) ON DELETE SET NULL
  ON UPDATE SET NULL
);






-- ************************************** `Project`

CREATE TABLE `Project`
(
 `projectId`    int NOT NULL AUTO_INCREMENT ,
 `numHour`      decimal NOT NULL CHECK (numHour>0),
 `name`         nvarchar(15) NOT NULL ,
 `dateBegin`    date NOT NULL CHECK( dateBegin>=NOW()),
 `dateEnd`      date NOT NULL ,
 `isFinish`     bit NOT NULL ,
 `customerName` nvarchar(15) NOT NULL ,
 `managerId`    int NOT NULL ,

PRIMARY KEY (`projectId`),
KEY `fkIdx_157` (`managerId`),
CONSTRAINT `FK_157` FOREIGN KEY `fkIdx_157` (`managerId`) REFERENCES `User` (`id`)  ON DELETE CASCADE
  ON UPDATE CASCADE
);






-- ************************************** `ProjectWorker`

CREATE TABLE `ProjectWorker`
(
 `projectId`       int NOT NULL ,
 `hoursForProject` decimal ,
 `id`              int NOT NULL ,

PRIMARY KEY (`projectId`, `id`),
KEY `fkIdx_151` (`projectId`),
CONSTRAINT `FK_151` FOREIGN KEY `fkIdx_151` (`projectId`) REFERENCES `Project` (`projectId`)  ON DELETE CASCADE
  ON UPDATE CASCADE,
KEY `fkIdx_185` (`id`),
CONSTRAINT `FK_185` FOREIGN KEY `fkIdx_185` (`id`) REFERENCES `User` (`id`)  ON DELETE CASCADE
  ON UPDATE CASCADE
);






-- ************************************** `PresentDay`

CREATE TABLE `PresentDay`
(
 `timeBegin`    datetime NOT NULL CHECK(timeBegin<=Now()),
 `presentDayId` int NOT NULL AUTO_INCREMENT ,
 `timeEnd`      datetime  ,
 `sumHours`     decimal CHECK(sumHours>=0),
 `id`           int NOT NULL ,
 `projectId`    int NOT NULL ,

PRIMARY KEY (`presentDayId`),
KEY `fkIdx_210` (`id`),
CONSTRAINT `FK_210` FOREIGN KEY `fkIdx_210` (`id`) REFERENCES `User` (`id`)  ON DELETE CASCADE
  ON UPDATE CASCADE,
KEY `fkIdx_213` (`projectId`),
CONSTRAINT `FK_213` FOREIGN KEY `fkIdx_213` (`projectId`) REFERENCES `Project` (`projectId`)  ON DELETE CASCADE
  ON UPDATE CASCADE
);






-- ************************************** `HourForDepartment`

CREATE TABLE `HourForDepartment`
(
 `projectId`    int NOT NULL ,
 `departmentId` int NOT NULL ,
 `sumHours`     decimal NOT NULL CHECK(sumHours>=0) ,

PRIMARY KEY (`projectId`, `departmentId`),
KEY `fkIdx_160` (`projectId`),
CONSTRAINT `FK_160` FOREIGN KEY `fkIdx_160` (`projectId`) REFERENCES `Project` (`projectId`),
KEY `fkIdx_172` (`departmentId`) ,
CONSTRAINT `FK_172` FOREIGN KEY `fkIdx_172` (`departmentId`) REFERENCES `Department` (`id`)  
);



DELIMITER //
CREATE PROCEDURE addProject11()
BEGIN

INSERT INTO `managertasks`.`project`
(`numHour`,`name`,`dateBegin`,`dateEnd`,`isFinish`,`customerName`,`managerId`)VALUES(1,'proj2','2018-12-12','2019-11-11',0,'rivka',6);

SET @projectId =LAST_INSERT_ID();
insert into managertasks.projectworker (projectId,id) 
select @projectId, u.id from user u  where u.managerId=6;


END;

DELIMITER $$
CREATE PROCEDURE `check_date`(IN dateBegin date, IN dateEnd date)
BEGIN
    IF DATEDIFF(dateEnd,dateBegin)<=0 THEN
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'check constraint on project.dateEnd failed';
    END IF;
 
END$$
 
DELIMITER ;


Third, create BEFORE INSERT and BEFORE UPDATE triggers. Inside the triggers, call the check_date() stored procedure.

-- before insert
DELIMITER $$
CREATE TRIGGER `project_before_insert` BEFORE INSERT ON `project`
FOR EACH ROW
BEGIN
IF new.dateEnd IS NOT NULL THEN
    CALL check_date(new.dateBegin,new.dateEnd);
    END IF;
END$$   
DELIMITER ; 


-- before update
DELIMITER $$
CREATE TRIGGER `project_before_update` BEFORE UPDATE ON `project`
FOR EACH ROW
BEGIN
IF new.dateEnd IS NOT NULL THEN
    CALL check_date(new.dateBegin,new.dateEnd);
END IF;
END$$   
DELIMITER ;



ALTER TABLE `managertasks`.`presentday` 
DROP FOREIGN KEY `FK_210`,
DROP FOREIGN KEY `FK_213`;
ALTER TABLE `managertasks`.`presentday` 
ADD CONSTRAINT `FK_210`
  FOREIGN KEY (`id`)
  REFERENCES `managertasks`.`user` (`id`)
  ON DELETE CASCADE
  ON UPDATE CASCADE,
ADD CONSTRAINT `FK_213`
  FOREIGN KEY (`projectId`)
  REFERENCES `managertasks`.`project` (`projectId`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;


 
 
 
`----------------UPDATE SUM HOUR IN PRESENT DAY`
 DELIMITER //
CREATE TRIGGER updatePresentDay44
BEFORE UPDATE
   ON presentday FOR EACH ROW

BEGIN
   SET NEW.`sumHours` = TIME_TO_SEC(  timediff(NEW.timeEnd, NEW.timeBegin ))/3600;
END;
 DELIMITER
 
 
 /////////change
 DELIMITER //
CREATE PROCEDURE addProject11()
BEGIN

INSERT INTO `managertasks`.`project`
(`numHour`,`name`,`dateBegin`,`dateEnd`,`isFinish`,`customerName`,`managerId`)VALUES(1,'proj2','2018-12-12','2019-11-11',0,'rivka',6);

SET @projectId =LAST_INSERT_ID();
insert into managertasks.projectworker (projectId,id) 
select @projectId, u.id from user u  where u.managerId=6;


END;

DELIMITER ;


`----------------ADD WORKER TO PROJECT`

DELIMITER //
CREATE TRIGGER insertProjectWorker
AFTER INSERT ON `user`
      FOR EACH ROW
      BEGIN
      SET @IDUSER=0;
        SELECT MAX(id) FROM user INTO @IDUSER;
       SET @IDMANAGER=NEW.managerId;
  
	  insert into managertasks.projectworker (projectId,id) 
	  select projectId, @IDUSER from managertasks.project p where p.managerId=@IDMANAGER ;
 
END ;
DELIMITER ;


`----------------UpdateProjectWorker`
DELIMITER //
CREATE TRIGGER UpdateProjectWorker
   AFTER UPDATE  ON `user`
    FOR EACH ROW
BEGIN
      DELETE FROM projectworker WHERE  id=OLD.id and projectId in (select projectId from managertasks.project p where p.managerId=OLD.managerId);
	  insert into managertasks.projectworker (projectId,id) 
	  select projectId, new.id from managertasks.project p where p.managerId=NEW.managerId ;
END 
DELIMITER




`----------------NULL DATE`
DELIMITER //
CREATE FUNCTION NullDate (_Input DATETIME) 
RETURNS BOOLEAN 
BEGIN 
IF (_Input = '0000-00-00') OR 
(_Input = '0000-00-00 00:00:00') THEN 
RETURN TRUE; 
ELSE 
RETURN FALSE; 
END IF; 
END;
DELIMITER


DELIMITER $$
 
CREATE FUNCTION IsFinishWorkToProject(idUser int, idProject int) RETURNS bit(1)
BEGIN

    DECLARE answer decimal(7,4);
	DECLARE sumHourToProject decimal(7,4);
	select SUM(sumHours) INTO answer FROM presentday WHERE id=idUser AND projectId=idProject; 
    select numHour into sumHourToProject from project where projectId=idProject;
    IF answer >= sumHourToProject THEN
     return(true);
    END IF;
 RETURN (false);
END


DELIMITER //
CREATE TRIGGER insertProjectWorker
AFTER INSERT ON `user`
      FOR EACH ROW
      BEGIN
      SET @IDUSER=0;
        SELECT MAX(id) FROM user INTO @IDUSER;
       SET @IDMANAGER=NEW.managerId;
  
	  insert into managertasks.projectworker (projectId,id) 
	  select projectId, @IDUSER from managertasks.project p where p.managerId=@IDMANAGER ;
 
END ;
DELIMITER ;

DELIMITER //
CREATE TRIGGER UpdateProjectWorker
   AFTER UPDATE  ON `user`
    FOR EACH ROW
BEGIN
      DELETE FROM projectworker WHERE  id= OLD.id and projectId in (select projectId from managertasks.project p where p.managerId=OLD.managerId);
	  insert into managertasks.projectworker (projectId,id) 
	  select projectId, new.id from managertasks.project p where p.managerId=NEW.managerId ;
END 

DELIMITER //
alter VIEW reportWorker
 AS 
 SELECT u.*,d.department,uu.userName as managerName ,sum(pp.sumHours) as doing,sum(sumHours)-u.numHourWork*5*4  as hourlastMonthMore,u.numHourWork*5*4 as needWork,
   (select uuu.numHourWork*5*4-sum(pd.sumHours) from user uuu left join presentday pd on uuu.id=pd.id where  MONTH(pd.timeBegin) = MONTH(CURRENT_DATE()) and year(pp.timeBegin)=year(CURRENT_DATE()) ) as thisMonthStay
   FROM user uu  join user u on u.managerId=uu.id left join presentday pp on u.id=pp.id join department d on d.id=u.departmentUserId
   where month(pp.timeBegin)=month(DATE_SUB(NOW(), INTERVAL 1 MONTH)) and year(pp.timeBegin)=year(CURRENT_DATE()) group by month(pp.timeBegin) and pp.id;

select * from reportWorker

select year(CURRENT_DATE())


select pd.*,u.userName,p.name from user u join presentday pd on pd.id=u.id join projectworker pw 
on pw.projectId=pd.projectId join project p on pw.projectId=p.projectId




use managertasks

set @kk='id=2'

select * from user where @kk

create procedure createReport(in fillter string)
begin



end

DELIMITER $$
create procedure CreateReport(in fillter NVARCHAR(20),in fillter2 NVARCHAR(20))
BEGIN
set @sql='SELECT
                    * 
                   FROM report';
if(fillter>'')  then        				
 set @sql = CONCAT(@sql,' where ',fillter,'=',fillter2);
end if;

PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
END;
DELIMITER;
call CreateReport('','1')




DELIMITER $$
alter VIEW report as
select p.*,
u.userName,(select count(*) from projectworker where p.projectId=projectId  group by projectId )as numWorker,
(select sum(sumHours) as sumHourWork from presentday where projectId=p.projectId group by projectId) as sumHourDo,
datediff(p.dateEnd,CURDATE()) as numDaysStay,
(select sum(sumHours) as sumHourWork from presentday where projectId=p.projectId group by projectId)/p.numHour*100 as presentDoing,
(p.numHour-(select sum(sumHours) as sumHourWork from presentday where projectId=p.projectId group by projectId)
)/datediff(p.dateEnd,CURDATE())/(select count(*) from projectworker where p.projectId=projectId  group by projectId ) as numHourDoDaysEveryWorker
from project p right join projectworker pw on pw.projectId=p.projectId right join presentday pd
on pw.id=pd.id  join user u on u.id=p.managerId group by p.projectId





select * from report 

select * from project where managerId=1

select * from project where isFinish=0


