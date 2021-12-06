SELECT  e.EmployeeID,
        e.FirstName,
		e.LastName,
		d.Name AS [DepartmentName]
        FROM Employees AS e
		INNER JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
		WHERE d.Name LIKE 'Sales'
		ORDER BY e.EmployeeID ASC