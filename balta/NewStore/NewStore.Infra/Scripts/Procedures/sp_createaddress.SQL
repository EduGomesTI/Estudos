DELIMITER $$

DROP PROCEDURE IF EXISTS sp_createaddress;

CREATE PROCEDURE sp_createaddress(
	  in _customerId int
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
BEGIN
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
END $$

DELIMITER ;
