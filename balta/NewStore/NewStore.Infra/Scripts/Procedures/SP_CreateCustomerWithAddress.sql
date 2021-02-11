delimiter $$

DROP PROCEDURE IF EXISTS sp_CreateCustomerWithAddress;

create procedure sp_CreateCustomerWithAddress
(
	in _firstname varchar(20)
    , in _lastname varchar(20)
    , in _document char(11)
    , in _email varchar(30)
    , in _phone varchar(13)
    , in _street varchar(100)
    , in _number varchar(10)
    , in _complement varchar(10)
    , in _district varchar(60)
    , in _city varchar(45)
    , in _state char(2)
    , in _country char(2)
    ,  in _zipCode char(8)
    , in _type int
)
begin

	DECLARE l_customer_id int default 0;
    
    start transaction;
    
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
    
    set l_customer_id = LAST_INSERT_ID();
    
    IF l_customer_id > 0 
    THEN    
		INSERT INTO address (
			CustomerId,
			Street,
			Number,
			Complement,
			District,
			City,
			State,
			Country,
			ZipCode,
			Type
		  )
		VALUES (        
			l_customer_id,
			_street,
			_number,
			_complement,
			_district,
			_city,
			_state,
			_country,
			_zipCode,
			_type
		  );
          
		commit;
	else
		rollback;
	end if;
end $$

delimiter ;