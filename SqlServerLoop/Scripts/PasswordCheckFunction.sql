/*
    Note this is hard coded to table Users1.
*/

CREATE OR ALTER FUNCTION Password_Check
(
    @v1 VARCHAR(500)
)
RETURNS VARCHAR(7)
AS
BEGIN
    DECLARE @result VARCHAR(7);


    SELECT @result = (CASE
                          WHEN [Password] = HASHBYTES('SHA2_512', @v1) THEN
                              'Valid'
                          ELSE
                              'Invalid'
                      END
                     )
    FROM Users1
    WHERE [Password] = HASHBYTES('SHA2_512', @v1);

    RETURN @result;
END;