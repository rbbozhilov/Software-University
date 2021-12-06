SELECT  c.CountryCode,
        mm.MountainRange,
		p.PeakName,
		p.Elevation
        FROM MountainsCountries AS mc
		INNER JOIN Peaks AS p ON p.MountainId = mc.MountainId
		INNER JOIN Countries AS c ON c.CountryCode = mc.CountryCode
		INNER JOIN Mountains AS mm ON mm.Id = mc.MountainId
		WHERE p.Elevation > 2835 AND c.CountryCode = 'BG'
		ORDER BY p.Elevation DESC