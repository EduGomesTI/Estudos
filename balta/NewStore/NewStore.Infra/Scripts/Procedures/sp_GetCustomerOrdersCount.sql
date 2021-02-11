--DELIMITER $$

DROP PROCEDURE IF EXISTS sp_GetCustomerOrdersCount;

CREATE PROCEDURE sp_GetCustomerOrdersCount(IN _document, OUT _id, OUT _name)
BEGIN
    SELECT
        c.Id INTO _id
        , CONCAT(c.FirstName, ' ', c.LastName) INTO _name
        , c.Document
    FROM    
        customer c
    INNER JOIN