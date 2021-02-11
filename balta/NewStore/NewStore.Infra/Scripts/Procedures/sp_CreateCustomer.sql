DELIMITER $$

DROP PROCEDURE IF EXISTS sp_CreateCustomer;

CREATE PROCEDURE sp_CreateCustomer(
	in _firstname varchar(20)
    , in _lastname varchar(20)
    , in _document char(11)
    , in _email varchar(30)
    , in _phone varchar(13)
)
begin
	insert into customer (
		Firstname
        , LastName
        , Document
        , Email
        , Phone
	)
    values (
    _firstName
    , _lastName
    , _document
    , _email
    , _phone
	);
end$$

DELIMITER ;
