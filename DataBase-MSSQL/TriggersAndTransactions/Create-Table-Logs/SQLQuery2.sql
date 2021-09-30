CREATE TABLE Logs 
(
	LogId INT IDENTITY(1,1) PRIMARY KEY,
	AccountId INT NOT NULL,
	OldSum MONEY NOT NULL,
	NewSum MONEY NOT NULL
)

GO


CREATE TRIGGER tr_ChangeSum
ON Accounts FOR UPDATE
AS
	INSERT INTO Logs (AccountId,OldSum,NewSum)  
	SELECT a.Id,d.Balance,i.Balance FROM Accounts AS a
			INNER JOIN inserted AS i ON i.Id = a.Id
			INNER JOIN deleted AS d ON d.Id = a.Id

GO

