
CREATE TABLE Subjects 
(
   SubjectID INT PRIMARY KEY,
   SubjectName VARCHAR(50) NOT NULL

)



CREATE TABLE Majors 
(
    MajorID INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL

)

CREATE TABLE Students 
(
    StudentID INT PRIMARY KEY,
	StudentNumber INT ,
	StudentName VARCHAR(50) NOT NULL,
	MajorID INT REFERENCES Majors(MajorID)
)

CREATE TABLE Agenda
(
    StudentID INT REFERENCES Students(StudentID),
	SubjectID INT REFERENCES Subjects(SubjectID),
	PRIMARY KEY (StudentID,SubjectID)
)


CREATE TABLE Payments
(
     PaymentID INT PRIMARY KEY,
	 PaymentDate DATE NOT NULL,
	 PaymentAmount DECIMAL NOT NULL,
	 StudentID INT REFERENCES Students(StudentID)
)