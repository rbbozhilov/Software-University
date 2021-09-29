CREATE PROCEDURE usp_EmployeesBySalaryLevel (@LevelOfSalary VARCHAR(10))
AS
	 SELECT FirstName AS [First Name],
			LastName AS [Last Name]
			FROM Employees
			WHERE dbo.ufn_GetSalaryLevel(Salary) = @LevelOfSalary

GO


EXECUTE usp_EmployeesBySalaryLevel 'High'