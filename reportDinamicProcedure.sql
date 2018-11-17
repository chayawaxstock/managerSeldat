SELECT * FROM managertasks.reportworker;

delimiter // 
CREATE PROCEDURE Report(IN viewName CHAR(64))
BEGIN
    SET @s = CONCAT('SELECT * FROM',viewName );
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END
//
delimiter ;