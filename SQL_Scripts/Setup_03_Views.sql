USE Correlated;
GO


IF OBJECT_ID('Maintenance.VW_MeasureDetails','V') IS NOT NULL
	DROP VIEW Maintenance.VW_MeasureDetails;
GO

CREATE VIEW Maintenance.VW_MeasureDetails 
AS
SELECT
      u.UnitName					'Unit',
	  uc.CategoryName				'Unit Category',
	  mr.RegionName Region,
	  mc.CountryName Country,
      MeasureName					'Name',
      MeasureDescription			'Description',
	  mct.CategoryName				'Measure Category'
FROM Correlated.Measure.Measure mm
INNER JOIN DataPoint.Unit u ON u.UnitID = mm.UnitID
INNER JOIN DataPoint.Category uc ON uc.CategoryID = u.CategoryID
INNER JOIN Measure.Region mr ON mr.RegionID = mm.RegionID
INNER JOIN Measure.Country mc ON mc.CountryID = mm.CountryID
INNER JOIN Measure.Category mct ON mct.CategoryID = mm.CategoryID
;
GO