 --Assignment 1--

use League;

Create table FootballLeague
(
	MatchID int Primary Key,
	TeamName1 nvarchar(100),
	TeamName2 nvarchar(100),
	[Status] nvarchar(10),
	WinningTeam nvarchar(100),
	Points int
);

ALTER TABLE FootballLeague
ADD Constraint Check_Status
	Check(FootballLeague.[Status] in ('Win','Draw'));

INSERT INTO FootBallLeague
	   VALUES   (1001,	'Italy',	'France',	'Win',	'France',	4),
				(1002,	'Brazil',	'Portugal',	'Draw',	null,	2),
				(1003,	'England',	'Japan',	'Win',	'England',	4),
				(1004,	'USA',	'Russia',	'Win',	'Russia',	4),
				(1005,	'Portugal',	'Italy',	'Draw',	null,	2),
				(1006,	'Brazil',	'France',	'Win',	'Brazil',	4),
				(1007,	'England',	'Russia',	'Win',	'Russia',	4),
				(1008,	'Japan',	'USA',	'Draw',	null,	2)




--Create a stored procedure to insert the records in FootBallLeague table.	

CREATE PROCEDURE spInsertFootballLeague
@Id int,
@TeamName1 nvarchar(100),
@TeamName2 nvarchar(100),
@Status nvarchar(10),
@WinningTeam nvarchar(100),
@Points int
AS
BEGIN
	INSERT	INTO FootballLeague
			VALUES (@Id, @TeamName1, @TeamName2, @Status, @WinningTeam, @Points);
END;



--a. Retrieve all the winning TeamNames.

SELECT WinningTeam 
FROM FootballLeague
WHERE WinningTeam Is Not Null;


--b.	Create View Match_View to display the teams whose status is Draw

CREATE VIEW MatchView
AS
	SELECT TeamName1 AS DrawTeams
	FROM FootballLeague
	WHERE [Status] = 'Draw'
	UNION ALL
	SELECT TeamName2
	FROM FootballLeague
	WHERE [Status] = 'Draw';


SELECT *
FROM MatchView

SELECT *
FROM FootballLeague