CREATE PROCEDURE usp_GetHoldersFullName 
AS
	SELECT  FirstName + ' ' + LastName AS [Full Name]
	        FROM AccountHolders AS acc

GO


EXEC usp_GetHoldersFullName