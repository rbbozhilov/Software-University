UPDATE Employees
         SET Salary = Salary + (0.12 * Salary)
		 WHERE JobTitle LIKE 'Engineering%' OR 
		       JobTitle LIKE 'Tool Design' OR 
			   JobTitle LIKE '%Marketing%' OR 
			   JobTitle LIKE 'Information Services%'

SELECT Salary
       FROM Employees
	   WHERE JobTitle LIKE 'Engineering%' OR 
		       JobTitle LIKE 'Tool Design' OR 
			   JobTitle LIKE '%Marketing%' OR 
			   JobTitle LIKE 'Information Services%'