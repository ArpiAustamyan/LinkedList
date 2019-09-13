CREATE TABLE Users
(
	UserId int not null IDENTITY(1,1) PRIMARY KEY ,
	firstname varchar(50) not null,
	lastname varchar(100) not null,
	birthday date  not null,
	height decimal,
	active bit not null
);

CREATE TABLE Markets
(
	MarketId int not null IDENTITY(1,1) PRIMARY KEY,
	marketname varchar(50) not null,
	phone int ,
	email varchar(100),
	city varchar(50),
	street varchar(50)
);

CREATE TABLE Cards
(
	 UserId int FOREIGN KEY REFERENCES Users(UserID),
	 MarketId int FOREIGN KEY REFERENCES Markets(MarketID)
);

INSERT INTO Users (firstname,lastname,birthday,active)
VALUES ('Hanna','Washington' ,'2011-02-11',1 );
INSERT INTO Users (firstname,lastname,birthday,active)
VALUES ('Any','Henderson' ,'2008-02-11',1 );
INSERT INTO Users (firstname,lastname,birthday,active)
VALUES ('Lucas','Simson' ,'1998-02-11',1 );
INSERT INTO Users (firstname,lastname,birthday,active)
VALUES ('Karen','Stepanyan' ,'2004-02-11',1 );
INSERT INTO Users (firstname,lastname,birthday,active)
VALUES ('Armen','Karapetyan' ,'2013-02-11',1);
INSERT INTO Users (firstname,lastname,birthday,active)
VALUES ('Karine','Hakobyan' ,'2011-02-11',1 );

SELECT * FROM Users;

UPDATE Users
SET active=0
WHERE firstname like'%A%' AND lastname like'%Y%';

SELECT * FROM Users;

DELETE from Users
WHERE UserId in (select top 1 UserID from Users order by UserID desc)

SELECT * FROM Users;

SELECT * FROM Users
Where active=1 AND (SELECT DATEDIFF (year, birthday,(SELECT CONVERT(date, getdate()))) as DATEDIFF)>=18

SELECT * FROM Users;