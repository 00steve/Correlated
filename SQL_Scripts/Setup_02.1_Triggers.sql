USE Correlated;
GO


IF OBJECT_ID('DataPoint.TRG_Point_IU','TR') IS NOT NULL
	DROP TRIGGER DataPoint.TRG_Point_IU;
GO


CREATE TRIGGER DataPoint.TRG_Point_IU
ON DataPoint.Point
AFTER INSERT, UPDATE--, DELETE
AS 
BEGIN
    SET NOCOUNT ON;

    UPDATE X 
    SET 
		NValue = CASE WHEN i.NValue IS NOT NULL THEN i.NValue ELSE i.SValue END,
		SValue = CASE WHEN i.SValue IS NOT NULL THEN i.SValue ELSE i.NValue END
    FROM DataPoint.Point X
    JOIN inserted i ON X.PointID = i.PointID
	SET NOCOUNT OFF;
END;
GO