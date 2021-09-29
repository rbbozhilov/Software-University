CREATE PROCEDURE usp_GetEmployeesFromTown (@TownName NVARCHAR(50))
AS
	SELECT  e.FirstName AS [First Name],e.LastName AS [Last Name] 
		FROM Employees AS e
		INNER JOIN Addresses AS a ON a.AddressID = e.AddressID
		INNER JOIN Towns AS t ON t.TownID = a.TownID
		WHERE t.Name = @TownName
	

GO

EXECUTE usp_GetEmployeesFromTown 'Sofia'


