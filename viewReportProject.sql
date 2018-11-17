CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY
 DEFINER VIEW `report` AS select `p`.`projectId` AS `projectId`,`p`.`numHour` 
 AS `numHour`,`p`.`name` AS `name`,`p`.`dateBegin` AS `dateBegin`,`p`.`dateEnd` 
 AS `dateEnd`,`p`.`isFinish` AS `isFinish`,`p`.`customerName` 
 AS `customerName`,`p`.`managerId` AS `managerId`,`u`.`userName` 
 AS `userName`,(select count(0) from `projectworker` 
 where (`p`.`projectId` = `projectworker`.`projectId`) 
 group by `projectworker`.`projectId`) 
 AS `numWorker`,(select sum(`presentday`.`sumHours`) 
 AS `sumHourWork` from `presentday` 
 where (`presentday`.`projectId` = `p`.`projectId`) 
 group by `presentday`.`projectId`)
 AS `sumHourDo`,(to_days(`p`.`dateEnd`) - to_days(curdate())) 
 AS `numDaysStay`,(((select sum(`presentday`.`sumHours`) AS
 `sumHourWork` from `presentday` where (`presentday`.`projectId` = `p`.`projectId`) 
 group by `presentday`.`projectId`) / `p`.`numHour`) * 100) 
 AS `presentDoing`,(((`p`.`numHour` - (select sum(`presentday`.`sumHours`) 
 AS `sumHourWork` from `presentday` where (`presentday`.`projectId` = `p`.`projectId`) 
 group by `presentday`.`projectId`)) / (to_days(`p`.`dateEnd`) - to_days(curdate()))) / (select count(0) from `projectworker` where (`p`.`projectId` = `projectworker`.`projectId`) group by `projectworker`.`projectId`)) 
 AS `numHourDoDaysEveryWorker` from ((`presentday` `pd` left join (`projectworker` `pw` 
 left join `project` `p` on((`pw`.`projectId` = `p`.`projectId`))) 
 on((`pw`.`id` = `pd`.`id`))) join `user` `u` on((`u`.`id` = `p`.`managerId`))) 
 group by `p`.`projectId`;
