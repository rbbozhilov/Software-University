
CREATE TABLE Manufacturers 
(
     ManufacturerID INT PRIMARY KEY NOT NULL,
	 [Name] VARCHAR(30) NOT NULL,
	 EstablishedOn DATE NOT NULL

)

CREATE TABLE Models 
(
    ModelID INT  PRIMARY KEY,
	[Name] VARCHAR(30) NOT NULL,
	ManufacturerID INT REFERENCES Manufacturers(ManufacturerID)

)



INSERT INTO Manufacturers VALUES (1,'BMW','07/03/1916')

INSERT INTO Manufacturers VALUES (2,'Tesla','01/01/2003') , 
								 (3,'Lada','01/05/1966')



INSERT INTO Models VALUES (101,'X1',1),
						  (102,'i6',1),
						  (103,'Model S',2),
						  (104,'Model X',2),
						  (105,'Model 3',2),
						  (106,'Nova',3)

SELECT m.Name, manu.Name, manu.EstablishedOn 
        FROM Models AS m 
		JOIN Manufacturers AS manu ON m.ManufacturerID = manu.ManufacturerID