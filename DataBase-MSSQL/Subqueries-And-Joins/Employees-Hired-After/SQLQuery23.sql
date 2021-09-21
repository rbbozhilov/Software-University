SELECT  e.FirstName,
        e.LastName,
		e.HireDate,
		d.Name AS [DeptName]
        FROM Employees AS e
		INNER JOIN Departments AS d ON d.DepartmentID =  e.DepartmentID
		WHERE HireDate > '1999-01-01' AND (d.Name = 'Sales' OR d.Name = 'Finance')
		ORDER BY HireDate ASC