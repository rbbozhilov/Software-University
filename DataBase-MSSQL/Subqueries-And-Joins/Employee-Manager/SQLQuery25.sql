SELECT  m.EmployeeID,
        m.FirstName,
		m.ManagerID,
		e.FirstName
        FROM Employees AS e
		INNER JOIN Employees AS m ON m.ManagerID = e.EmployeeID
		WHERE m.ManagerID = 3 OR m.ManagerID = 7
		ORDER BY EmployeeID ASC