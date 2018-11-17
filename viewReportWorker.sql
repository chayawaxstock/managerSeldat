CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` 
SQL SECURITY DEFINER VIEW `reportworker` 
AS select `u`.`id` AS `id`,`u`.`userName`
 AS `userName`,`u`.`userComputer` 
 
 AS `userComputer`,`u`.`password` 
 AS `password`,`u`.`departmentUserId` 
 AS `departmentUserId`,`u`.`email` 
 AS `email`,`u`.`numHourWork` AS `numHourWork`,`u`.`managerId` 
 AS `managerId`,`d`.`department` AS `department`,`uu`.`userName` 
 AS `managerName`,sum(`pp`.`sumHours`) AS `doing`,
 (sum(`pp`.`sumHours`) - ((`u`.`numHourWork` * 5) * 4)) 
 AS `hourlastMonthMore`,((`u`.`numHourWork` * 5) * 4) 
 AS `needWork`,(select (((`uuu`.`numHourWork` * 5) * 4) - sum(`pd`.`sumHours`))
 
 from (`user` `uuu` left join `presentday` `pd` on((`uuu`.`id` = `pd`.`id`))) 
 where ((month(`pd`.`timeBegin`) = month(curdate())) 
 and (year(`pp`.`timeBegin`) = year(curdate())))) 
 AS `thisMonthStay` from (((`user` `uu` join `user` `u`
 on((`u`.`managerId` = `uu`.`id`))) left join `presentday` `pp` 
 on((`u`.`id` = `pp`.`id`))) join `department` `d` 
 on((`d`.`id` = `u`.`departmentUserId`))) 
 where ((month(`pp`.`timeBegin`) = month((now() - interval 1 month))) 
 and (year(`pp`.`timeBegin`) = year(curdate())))
 group by (month(`pp`.`timeBegin`) and (`pp`.`id` <> 0));
 
 
 DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Report`(IN viewName CHAR(64))
BEGIN
    SET @sqls = CONCAT('SELECT * FROM ',viewName );
    PREPARE stmt FROM @sqls;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$
DELIMITER ;

