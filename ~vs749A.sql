CREATE TABLE Players
(
	PlayerId int not null IDENTITY(1,1) PRIMARY KEY ,
	firstname varchar(50) not null,
	lastname varchar(100) not null,
	TeamId int FOREIGN KEY REFERENCES Teams (TeamId)
);

CREATE TABLE Shoes 
(
	ShoesId int not null IDENTITY(1,1) PRIMARY KEY ,
	size  int not null,
	brandname varchar(50),
	createdate date,
	PlayerId int FOREIGN KEY REFERENCES Players(PlayerID)
);

CREATE TABLE Teams
(
	TeamId int not null IDENTITY(1,1) PRIMARY KEY ,
	team_name varchar(50) not null,
	country varchar(50)
);


INSERT INTO Teams (team_name)
VALUES ('REAL MADRID');
INSERT INTO Teams (team_name)
VALUES ('BARCELONA');
INSERT INTO Players (firstname,lastname,TeamId)
VALUES ('Sergio','Ramos' ,1 );
INSERT INTO Players (firstname,lastname,TeamId)
VALUES ('Iker','Casilias' ,1 );
INSERT INTO Players(firstname,lastname,TeamId)
VALUES ('Gregor','Henderson' ,2 );


SELECT team_name ,Count(Teams.TeamId) as players_count
FROM Teams
FULL OUTER JOIN Players 
ON Teams.TeamId = Players.TeamId
group by team_name
having Count(Teams.TeamId)>=2