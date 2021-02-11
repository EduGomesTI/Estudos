DELIMITER $$

DROP PROCEDURE IF EXISTS sp_CheckEmail;

CREATE PROCEDURE sp_CheckEmail(IN _email varchar(30), OUT _qtde INT)
BEGIN
    SELECT COUNT(Id) INTO _qtde
    FROM customer
    WHERE Email = _email;
END $$

DELIMITER ;