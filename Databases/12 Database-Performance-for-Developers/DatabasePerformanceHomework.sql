CREATE TABLE Logs(
  Id int NOT NULL IDENTITY,
  LogDate datetime,
  MsgText nvarchar(300),
  CONSTRAINT PK_Logs_Id PRIMARY KEY (Id)
)
GO

CREATE PROC usp_Add1MilionLogs
AS
DECLARE @Counter int = 0
WHILE (SELECT COUNT(*) FROM Logs) < 1000000
BEGIN
  INSERT INTO Logs(LogDate, MsgText)
  SELECT DATEADD(MONTH, @Counter + 3, LogDate), MsgText + CONVERT(varchar, @Counter) FROM Logs
  SET @Counter = @Counter + 1
END
GO

EXEC usp_Add1MilionLogs
GO

--Empty the SQL Server cache
CHECKPOINT; DBCC DROPCLEANBUFFERS; 

--Test search by date before adding index takes 2 seconds
SELECT MsgText 
FROM Logs 
WHERE LogDate BETWEEN CONVERT(datetime, '1990-01-01') AND CONVERT(datetime, '1995-01-01');

-- Task 2
-- Add a index to the date column
CREATE INDEX IDX_OnLogsDateColumn ON Logs(LogDate);

--Empty the SQL Server cache
CHECKPOINT; DBCC DROPCLEANBUFFERS; 

--Test search by date after adding index takes 1 second
SELECT MsgText 
FROM Logs 
WHERE LogDate BETWEEN CONVERT(datetime, '1990-01-01') AND CONVERT(datetime, '1995-01-01');