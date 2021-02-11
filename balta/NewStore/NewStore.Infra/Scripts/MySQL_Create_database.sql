CREATE SCHEMA `newstore` ;

CREATE TABLE `newstore`.`Customer` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(20) NOT NULL,
  `LastName` VARCHAR(20) NOT NULL,
  `Document` VARCHAR(11) NOT NULL,
  `Email` VARCHAR(30) NOT NULL,
  `Phone` VARCHAR(13) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE);

CREATE TABLE `newstore`.`address` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `CustomerId` INT NOT NULL,
  `Street` VARCHAR(100) NOT NULL,
  `Number` VARCHAR(4) NOT NULL,
  `Complement` VARCHAR(10) NOT NULL,
  `District` VARCHAR(60) NOT NULL,
  `City` VARCHAR(45) NOT NULL,
  `State` CHAR(2) NOT NULL,
  `Country` CHAR(2) NOT NULL,
  `ZipCode` CHAR(8) NOT NULL,
  `Type` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  UNIQUE INDEX `CustomerId_UNIQUE` (`CustomerId` ASC) VISIBLE);

    ALTER TABLE `newstore`.`address` 
    ADD CONSTRAINT `FK_Address_Customer`
    FOREIGN KEY (`CustomerId`)
    REFERENCES `newstore`.`customer` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE;    

  CREATE TABLE `newstore`.`product` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(255) NOT NULL,
  `Description` TEXT NOT NULL,
  `Image` VARCHAR(1040) NULL,
  `price` DECIMAL(10,2) NOT NULL,
  `QuatityOnHand` DECIMAL(10,2) NOT NULL,
  `productcol` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE); 

  CREATE TABLE `newstore`.`order` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `CustomerId` INT NOT NULL,
  `CreateDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE);

  ALTER TABLE `newstore`.`order` 
    ADD INDEX `FK_Order_Customer_idx` (`CustomerId` ASC) VISIBLE;
    ;
    ALTER TABLE `newstore`.`order` 
    ADD CONSTRAINT `FK_Order_Customer`
  FOREIGN KEY (`CustomerId`)
  REFERENCES `newstore`.`customer` (`Id`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;


  CREATE TABLE `newstore`.`orderitem` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `OrderId` INT NOT NULL,
  `ProductId` INT NOT NULL,
  `Quantity` DECIMAL(10,2) NOT NULL,
  `Price` DECIMAL(10,2) NOT NULL,
  `orderitemcol` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE);

  ALTER TABLE `newstore`.`orderitem` 
ADD INDEX `FK_OrderItem_Order_idx` (`OrderId` ASC) VISIBLE,
ADD INDEX `FK_OrderItem_Product_idx` (`ProductId` ASC) VISIBLE;
;
ALTER TABLE `newstore`.`orderitem` 
ADD CONSTRAINT `FK_OrderItem_Order`
  FOREIGN KEY (`OrderId`)
  REFERENCES `newstore`.`order` (`Id`)
  ON DELETE CASCADE
  ON UPDATE CASCADE,
ADD CONSTRAINT `FK_OrderItem_Product`
  FOREIGN KEY (`ProductId`)
  REFERENCES `newstore`.`product` (`Id`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;

  CREATE TABLE `newstore`.`delivery` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `OderId` INT NOT NULL,
  `CreateDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `EstimatedDelivertDate` DATETIME NOT NULL,
  `Status` INT NOT NULL,
  PRIMARY KEY (`Id`));

ALTER TABLE `newstore`.`delivery` 
ADD INDEX `FK_Delivery_Order_idx` (`OderId` ASC) VISIBLE;
;
ALTER TABLE `newstore`.`delivery` 
ADD CONSTRAINT `FK_Delivery_Order`
  FOREIGN KEY (`OderId`)
  REFERENCES `newstore`.`order` (`Id`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;