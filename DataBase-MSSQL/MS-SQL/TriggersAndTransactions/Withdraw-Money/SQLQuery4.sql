CREATE PROCEDURE usp_WithdrawMoney (@AccountId INT, @MoneyAmount DECIMAL(18,4))
AS
  BEGIN TRANSACTION 

		DECLARE @Account INT = (SELECT COUNT(*) FROM Accounts WHERE @AccountId = Id);

		IF(@Account = 0)
		BEGIN
			ROLLBACK;
			THROW 50001 , 'Invalid Account Id',1;
		END

		IF(@MoneyAmount < 0)
		BEGIN
			ROLLBACK;
			THROW 50002 , 'Negative Number',1;
		END

		UPDATE Accounts
			SET Balance -= @MoneyAmount
			WHERE @AccountId = Id


  COMMIT

GO


EXEC usp_WithdrawMoney 5,25

SELECT * FROM Accounts WHERE Id = 5