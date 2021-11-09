SELECT ISNULL(e.FirstName + ' ' + e.LastName,'None') AS Employee
,  ISNULL(d.Name,'None') AS Department
, c.Name AS Category
,r.Description
,FORMAT(r.OpenDate,'dd.MM.yyyy')
,s.Label AS Status
, ue.Name AS [User]
		FROM Reports AS r
		 LEFT JOIN Employees AS e ON e.Id = r.EmployeeId
		 LEFT JOIN Departments AS d ON e.DepartmentId = d.Id
		 LEFT JOIN Categories AS c ON r.CategoryId = c.Id
		 LEFT JOIN Status AS s ON r.StatusId = s.Id
		 LEFT JOIN Users AS ue ON ue.Id = r.UserId
		ORDER BY e.FirstName DESC,e.LastName DESC,d.Name ASC,c.Name ASC , r.Description ASC,OpenDate ASC , s.Label ASC , ue.Name ASC