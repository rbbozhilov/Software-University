SELECT DISTINCT SUBSTRING(FirstName, 1, 1) 
        FROM WizzardDeposits
		WHERE DepositGroup  = 'Troll Chest'
		GROUP BY SUBSTRING(FirstName, 1, 1)
		ORDER BY SUBSTRING(FirstName, 1, 1) ASC