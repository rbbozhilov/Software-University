SELECT 
        DepartmentID,
        MIN(Salary) AS MinimumSalary
        FROM Employees
		WHERE DepartmentID = 2 OR DepartmentID = 5 OR DepartmentID = 7 AND HireDate > '2000-01-01'
		GROUP BY DepartmentID