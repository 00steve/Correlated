USE Correlated;

--references datapoint.date
IF OBJECT_ID('DataPoint.Point','U') IS NOT NULL
	DROP TABLE DataPoint.Point;

IF OBJECT_ID('DataPoint.Date','U') IS NOT NULL
	DROP TABLE DataPoint.Date;

--references measure.measure, measure.category
IF OBJECT_ID('Measure.MeasureCategory','U') IS NOT NULL
	DROP TABLE Measure.MeasureCategory; 

--references measure
IF OBJECT_ID('Measure.Source','U') IS NOT NULL
	DROP TABLE Measure.[Source]; 

--references datapoint.unit
IF OBJECT_ID('Measure.Measure','U') IS NOT NULL
	DROP TABLE Measure.Measure;

--references datapoint.category
IF OBJECT_ID('DataPoint.Unit','U') IS NOT NULL
	DROP TABLE DataPoint.Unit;

IF OBJECT_ID('DataPoint.Category','U') IS NOT NULL
	DROP TABLE DataPoint.Category;

IF OBJECT_ID('Measure.Category','U') IS NOT NULL
	DROP TABLE Measure.Category;

--references measure.region
IF OBJECT_ID('Measure.Country','U') IS NOT NULL
	DROP TABLE Measure.Country;

IF OBJECT_ID('Measure.Region','U') IS NOT NULL
	DROP TABLE Measure.Region;

CREATE TABLE  DataPoint.Category(
	CategoryID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(100) NOT NULL
);


CREATE TABLE DataPoint.Unit(
	UnitID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	CategoryID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES DataPoint.Category(CategoryID),
	UnitName VARCHAR(50) NOT NULL,
	UnitDescription VARCHAR(1000)
);



CREATE TABLE  Measure.Category(
	CategoryID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(100) NOT NULL
);

CREATE TABLE Measure.Region(
	RegionID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	RegionName VARCHAR(100)
);

CREATE TABLE Measure.Country(
	CountryID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	CurrentRegionID NUMERIC(20,0) FOREIGN KEY REFERENCES Measure.Region(RegionID),
	CountryName VARCHAR(300)
);

CREATE TABLE Measure.Measure(
	MeasureID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	UnitID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES DataPoint.Unit(UnitID),
	CategoryID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES Measure.Category(CategoryID),
	RegionID NUMERIC(20,0) FOREIGN KEY REFERENCES Measure.Region(RegionID),
	CountryID NUMERIC(20,0) FOREIGN KEY REFERENCES Measure.Country(CountryID),
	MeasureName VARCHAR(200) NOT NULL,
	MeasureDescription VARCHAR(1000)
);

CREATE TABLE Measure.MeasureCategory(
	MeasureCategoryID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	MeasureID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES Measure.Measure(MeasureID),
	CategoryID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES Measure.Category(CategoryID)
);

CREATE TABLE Measure.[Source](
	SourceID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	MeasureID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES Measure.Measure(MeasureID),
	SourceName VARCHAR(200) NOT NULL,
	SourceDescription VARCHAR(1000),
	SourceURL VARCHAR(1000) NOT NULL
);




CREATE TABLE DataPoint.[Date] (
	DateID NUMERIC(20,0) PRIMARY KEY IDENTITY(1,1),
	DT DATETIME2(0) NOT NULL
);



CREATE TABLE DataPoint.Point (
	PointID NUMERIC(30,0) PRIMARY KEY IDENTITY(1,1),
	DateID NUMERIC(20,0) NOT NULL FOREIGN KEY REFERENCES DataPoint.[Date](DateID),
	NValue NUMERIC(38,15),
	/*the string value for the point. If it is a numeric value, the string value is 
	generated on update or insert.*/
	SValue VARCHAR(1000),
	/*if the data point was created by a new DataPoint.Date being added between two 
	datapoints that are used by the dataset. If a datapoint is retrieved from a legit
	source, this flag (should) be 0*/
	Interpolated BIT NOT NULL
);