CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(50), @word VARCHAR(50)) 
RETURNS BIT
AS
BEGIN
DECLARE @CIndex INT = 1;

WHILE(@CIndex <= LEN(@word))
	BEGIN

	DECLARE @CLetter varchar(1) = SUBSTRING(@word, @CIndex, 1);

	IF(CHARINDEX(@CLetter, @setOfLetters)) = 0
	BEGIN
	RETURN 0;
	END

	SET @CIndex += 1;
	END

RETURN 1;
END