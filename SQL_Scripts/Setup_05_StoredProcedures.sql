USE Correlated;
GO

IF OBJECT_ID('Maintenance.SliceDataPoints','P') IS NOT NULL
	DROP PROCEDURE Maintenance.SliceDataPoints;
GO


CREATE PROCEDURE Maintenance.SliceDataPoints
	@startDateID NUMERIC(20,0),
	@endDateID NUMERIC(20,0),
	@newDateID NUMERIC(20,0)
AS
	--DECLARE @startDate DATETIME2(0);
	--DECLARE @endDate DATETIME2(0);
	--DECLARE @newDate DATETIME2(0);
BEGIN
	--get dates from date ids (I DON'T THINK I NEED THIS)
	--SET @startDate = (SELECT DT FROM DataPoint.[Date] WHERE DateID = @startDateID);
	--SET @endDate = (SELECT DT FROM DataPoint.[Date] WHERE DateID = @endDateID);
	--SET @newDate = (SELECT DT FROM DataPoint.[Date] WHERE DateID = @newDateID);

	PRINT 'Find any measures that have a point with a date matching both the start date and end date';
	PRINT 'I don''t think we care about any measures where the new point is out of its bounds because';
	PRINT 'adding a new point to that measure would be extrapolation and we''re not into that shit.';

END;