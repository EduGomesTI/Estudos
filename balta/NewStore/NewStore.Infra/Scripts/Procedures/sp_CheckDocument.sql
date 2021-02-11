DELIMITER $$

DROP PROCEDURE IF EXISTS sp_CheckDocument;

CREATE PROCEDURE sp_CheckDocument(IN _document char(11), OUT _qtde INT)
BEGIN
    SELECT COUNT(Id) INTO _qtde
    FROM customer
    WHERE Document = _document;
END $$

DELIMITER ;