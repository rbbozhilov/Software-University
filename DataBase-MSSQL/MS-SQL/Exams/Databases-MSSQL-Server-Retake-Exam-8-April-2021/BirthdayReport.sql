SELECT u.Username,c.Name AS CategoryName
		FROM Reports AS r
		JOIN Categories AS c ON c.Id = r.CategoryId
		JOIN Users AS u ON u.Id = r.UserId
		WHERE FORMAT(u.Birthdate,'dd-MM') = FORMAT(r.OpenDate,'dd-MM')
		ORDER BY u.Username ASC,c.Name ASC