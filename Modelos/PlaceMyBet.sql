CREATE DATABASE if NOT EXISTS `PlaceMyBet` DEFAULT CHARACTER SET UTF8; 

USE `PlaceMyBet`;

CREATE TABLE if NOT EXISTS `Evento`
(`idEvento` INT NOT NULL,
`local` VARCHAR(45) NOT NULL,
`visitante` VARCHAR(45) NOT NULL,
`fecha` DATE NOT NULL,
PRIMARY KEY (`idEvento`));

CREATE TABLE if NOT EXISTS `Mercado 1.5`
(`idEvento` INT NOT NULL,
`cuotaOver` DECIMAL(5,2) NOT NULL,
`cuotaUnder` DECIMAL(5,2) NOT NULL,
`dineroOver` DECIMAL(5,2) NOT NULL,
`dineroUnder` DECIMAL(5,2) NOT NULL,
PRIMARY KEY (`idEvento`),
CONSTRAINT `relacionEvento1.5` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`));

CREATE TABLE if NOT EXISTS `Mercado 2.5`
(`idEvento` INT NOT NULL,
`cuotaOver` DECIMAL(5,2) NOT NULL,
`cuotaUnder` DECIMAL(5,2) NOT NULL,
`dineroOver` DECIMAL(5,2) NOT NULL,
`dineroUnder` DECIMAL(5,2) NOT NULL,
PRIMARY KEY (`idEvento`),
CONSTRAINT `relacionEvento2.5` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`));

CREATE TABLE if NOT EXISTS `Mercado 3.5`
(`idEvento` INT NOT NULL,
`cuotaOver` DECIMAL(5,2) NOT NULL,
`cuotaUnder` DECIMAL(5,2) NOT NULL,
`dineroOver` DECIMAL(5,2) NOT NULL,
`dineroUnder` DECIMAL(5,2) NOT NULL,
PRIMARY KEY (`idEvento`),
CONSTRAINT `relacionEvento3.5` FOREIGN KEY (`idEvento`) REFERENCES `evento` (`idEvento`));

CREATE TABLE if NOT EXISTS `Cuenta Bancaria`
(`numCuenta` VARCHAR(45) NOT NULL,
`saldo`DECIMAL(10,2) NOT NULL,
`nombreBanco` VARCHAR (45) NOT NULL,
`numTarjeta` INT NOT NULL,
PRIMARY KEY (`numCuenta`));

CREATE TABLE if NOT EXISTS `Usuario`
(`gmail` VARCHAR(50) NOT NULL,
`nombre` VARCHAR(45) NOT NULL,
`apellido`VARCHAR(45) NOT NULL,
`edad` INT NOT NULL,
`numCuenta` VARCHAR(45),
PRIMARY KEY(`gmail`),
CONSTRAINT `relacionCuenta` FOREIGN KEY (`numCuenta`) REFERENCES `Cuenta Bancaria` (`numCuenta`)
);

CREATE TABLE if NOT EXISTS `Apuesta`
(`idApuesta` INT NOT NULL,
`idEvento` INT NOT NULL,
`tipoMercado` VARCHAR(45) NOT NULL,
`cuota` DECIMAL(5,2) NOT NULL,
`dinero` DECIMAL(10,2) NOT NULL,
`fecha` DATE NOT NULL,
`gmail`VARCHAR(50) NOT NULL,
PRIMARY KEY (`idApuesta`),
CONSTRAINT `relacionUsuario` FOREIGN KEY (`gmail`) REFERENCES `Usuario` (`gmail`),
CONSTRAINT `relacionEvento` FOREIGN KEY (`idEvento`) REFERENCES `Evento` (`idEvento`)
);


INSERT INTO `Usuario` (gmail, nombre, apellido, edad) VALUES ('adbaro@gmail.com','Adrian','Ballesteros', 20);
INSERT INTO `Evento` VALUES (1,'Valencia','Espanyol', '2020-09-20');
INSERT INTO `Mercado 1.5` VALUES (1,1.45,2.85,100,50);
INSERT INTO `Mercado 2.5` VALUES (1,1.9,1.9,100,100);
INSERT INTO `Mercado 3.5` VALUES (1,2.85,2.43,50,100);
INSERT INTO `Cuenta Bancaria` VALUES ('123456789', 500.25, 'Bankia', 123456789);
UPDATE `Usuario` SET `numCuenta` = '123456789' WHERE `gmail` = 'adbaro@gmail.com';
INSERT INTO `Apuesta` VALUES (1,1,'1.5', 1.2, 30.3, '2020-09-19', 'adbaro@gmail.com'); 