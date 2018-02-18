USE Correlated;
GO


IF (SELECT COUNT(*) FROM DataPoint.Category) = 0 BEGIN
	INSERT INTO DataPoint.Category VALUES('Currency'); --id = 1
	INSERT INTO DataPoint.Category VALUES('Energy');
END;



IF (SELECT COUNT(*) FROM Measure.Category) = 0 BEGIN
	INSERT INTO Measure.Category VALUES('Economics');	--id = 1
	INSERT INTO Measure.Category VALUES('Weather');		--id = 2
	INSERT INTO Measure.Category VALUES('Health');		--id = 3
	INSERT INTO Measure.Category VALUES('Technology');	--id = 4
	INSERT INTO Measure.Category VALUES('Politics');	--id = 5
	INSERT INTO Measure.Category VALUES('Society');		--id = 6
	INSERT INTO Measure.Category VALUES('Culture');		--id = 7
	INSERT INTO Measure.Category VALUES('Crime');		--id = 8
END;



IF (SELECT COUNT(*) FROM DataPoint.Unit) = 0 BEGIN
	INSERT INTO DataPoint.Unit VALUES(1,'USD','The United States of America''s dollar'); --1
END;



IF (SELECT COUNT(*) FROM Measure.Region) = 0 BEGIN
	INSERT INTO Measure.Region VALUES('Africa');				--id 1
	INSERT INTO Measure.Region VALUES('Asia');					--id 2
	INSERT INTO Measure.Region VALUES('North America');			--id 3
	INSERT INTO Measure.Region VALUES('South America');			--id 4
	INSERT INTO Measure.Region VALUES('Central America');		--id 5
	INSERT INTO Measure.Region VALUES('Eastern Europe');		--id 6
	INSERT INTO Measure.Region VALUES('the European Union');	--id 7
	INSERT INTO Measure.Region VALUES('the Middle East');		--id 8
	INSERT INTO Measure.Region VALUES('the Caribbean');			--id 9
	INSERT INTO Measure.Region VALUES('Oceania');				--id 10
END;


IF (SELECT COUNT(*) FROM Measure.Country) = 0 BEGIN
	INSERT INTO Measure.Country VALUES(3,'United States of America');
END;


IF (SELECT COUNT(*) FROM Measure.Measure) = 0 BEGIN
	INSERT INTO Measure.Measure VALUES(1,1,3,1,'Price per gallon of gasoline','The average price in [USD] of a gallon of gas');

END;