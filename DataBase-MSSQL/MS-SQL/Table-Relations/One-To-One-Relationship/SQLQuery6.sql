CREATE TABLE Passports 
(
    PassportID INT PRIMARY KEY NOT NULL,
	PassportNumber VARCHAR(50) NOT NULL


)

CREATE TABLE Persons 
(
    PersonID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL,
	Salary DECIMAL NOT NULL,
	PassportID INT REFERENCES Passports(PassportID) UNIQUE

)

INSERT INTO Passports VALUES (101,'N34FG21B')

INSERT INTO Passports VALUES (102,'K65LO4R7') ,
					         (103,'ZE657QP2')

INSERT INTO Persons VALUES ('Roberto',43300.00,102),
						   ('Tom',56100.00,103),
						   ('Yana',60200.00,101)

SELECT p.FirstName,p.Salary,pass.PassportNumber 
         FROM Persons AS p
		 JOIN Passports AS pass ON p.PassportID = pass.PassportID


