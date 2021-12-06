SELECT TOP(5)
        e.EmployeeID,
		e.FirstName,
		p.Name AS [ProjectName]
        FROM EmployeesProjects AS ep
		INNER JOIN Employees AS e ON e.EmployeeID = ep.EmployeeID
		INNER JOIN Projects AS p ON p.ProjectID = ep.ProjectID
		WHERE p.StartDate > '2002-08-13' AND p.EndDate IS NULL
		ORDER BY e.EmployeeID ASC

	     