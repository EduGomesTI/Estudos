DELIMITER $$

DROP PROCEDURE IF EXISTS sp_last_id;

CREATE PROCEDURE sp_last_id(IN _table varchar(30), OUT _id INT)
BEGIN
    SELECT Max(Id) INTO _id
    FROM _table;
END $$

DELIMITER ;