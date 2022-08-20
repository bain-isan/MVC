 use BusManagement

CREATE TABLE BusInfo
(
	BusID INT Identity(1,1) PRIMARY KEY,
	BoardingPoint NVARCHAR(3),
	TravelDate DATE,
	Amount DECIMAL(5,2),
	Rating INT
);

INSERT	INTO BusInfo(BoardingPoint, TravelDate, Amount, Rating)
		VALUES	('BGL',	'2017-06-18',	400.65,	2),
				('HYD',	'2017-10-05',	600.00,	3),
				('CHN',	'2016-07-25',	445.95,	3),
				('PUN',	'2017-12-10',	543.00,	4),
				('MUM',	'2017-01-28',	500.50,	4),
				('PUN',	'2016-03-27',	333.55,	3),
				('MUM',	'2016-11-06',	510.00,	4);


CREATE PROCEDURE spInsertBusInfo
@BoardingPoint NVARCHAR(3),
@TravelDate DATE,
@Amount DECIMAL(5,2),
@Rating INT
AS
BEGIN
	INSERT	INTO BusInfo(BoardingPoint, TravelDate, Amount, Rating)
		VALUES	(@BoardingPoint,	@TravelDate,	@Amount,	@Rating);
END;

--Retrieve all BoardingPoint and TravelDate for the amount which is greater than 450.
SELECT BoardingPoint, TravelDate
FROM BusInfo
WHERE Amount > 450;

--a.Create View Bus_View to display the BusID, BoardingPoint whose rating is greater than 3
CREATE VIEW Bus_View
AS
	SELECT BusID, BoardingPoint
	FROM BusInfo
	WHERE Rating > 3;

SELECT *
FROM Bus_View