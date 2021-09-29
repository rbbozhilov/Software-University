CREATE PROCEDURE usp_GetTownsStartingWith (@String NVARCHAR(50))
AS
	SELECT [Name] AS Town
	       FROM Towns
		   WHERE [Name] LIKE @String + '%'

GO


EXECUTE usp_GetTownsStartingWith 'b'