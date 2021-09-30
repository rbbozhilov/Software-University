CREATE PROCEDURE usp_TransferMoney(@SenderId INT , @ReceiverId INT , @Amount DECIMAL(18,4))
AS

	BEGIN TRANSACTION

		DECLARE @ReceiverAccount INT = (SELECT COUNT(*) FROM Accounts WHERE Id = @ReceiverId);
		DECLARE @SenderAccount INT = (SELECT COUNT(*) FROM Accounts WHERE Id = @SenderId);
		DECLARE @SenderAmount DECIMAL(18,4) = (SELECT Balance FROM Accounts WHERE Id = @SenderId);
		SET @SenderAmount -= @Amount;


		IF(@ReceiverAccount = 0 OR @SenderAccount = 0 )
			BEGIN
			    ROLLBACK;
				THROW 50001 , 'Invalid id',1;
			END

		IF(@Amount < 0 )
			BEGIN
				ROLLBACK;
				THROW 50001 , 'Negative amount',1;
			END

		IF(@SenderAmount < 0)
			BEGIN
				ROLLBACK;
				THROW 50001 , 'Negative amount',1;
			END
		

		EXECUTE [dbo].[usp_WithdrawMoney] @SenderId,@Amount
		EXECUTE [dbo].[usp_DepositMoney] @ReceiverId,@Amount

	COMMIT

GO


EXECUTE usp_TransferMoney 5,1,5000

SELECT * FROM Accounts WHERE Id = 1 OR Id = 5