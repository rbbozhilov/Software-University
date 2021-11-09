SELECT TOP(5) c.Name AS CategoryName , COUNT(*) AS ReportsNumber 
		FROM Reports AS r
		JOIN Categories AS c ON r.CategoryId = c.Id
		GROUP BY c.Id,c.Name
		ORDER BY ReportsNumber DESC,CategoryName ASC