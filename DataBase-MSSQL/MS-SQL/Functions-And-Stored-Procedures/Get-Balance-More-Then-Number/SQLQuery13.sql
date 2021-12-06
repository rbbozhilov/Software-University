
CREATE OR ALTER PROCEDURE usp_GetHoldersWithBalanceHigherThan (@Number MONEY)
AS
     
	 SELECT  h.FirstName AS [First Name]
	        ,h.LastName AS [Last Name] 
	         FROM AccountHolders AS h
			 INNER JOIN Accounts AS a ON a.AccountHolderId = h.Id
			 GROUP BY h.FirstName , h.LastName
			 HAVING SUM(a.Balance) > @Number
			 ORDER BY h.FirstName ASC,h.LastName ASC

GO


EXEC usp_GetHoldersWithBalanceHigherThan 50000

