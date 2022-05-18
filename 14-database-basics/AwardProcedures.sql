--Procedures for Award
USE FilmAwards

GO

------------------------------------
CREATE PROCEDURE AddAward
	@Title NVARCHAR(50),
	@Description NVARCHAR(250)
AS
INSERT INTO Awards(Title, [Description])
	VALUES(@Title, @Description)

-------------------------------------
CREATE PROCEDURE RemoveAward
	@AwardID INT
AS
DELETE FROM Awards WHERE 		
	ID = @AwardID

-------------------------------------
CREATE PROCEDURE GetAward
	@AwardID INT
AS
SELECT * FROM Awards
	WHERE ID = @AwardID

-------------------------------------
CREATE PROCEDURE OrderAwardByField
	@FieldIndex INT,
	@SortStep INT
AS
if @SortStep = 1
begin
	if @FieldIndex = 0
		SELECT * FROM Awards
		ORDER BY 1
	if @FieldIndex = 1
		SELECT * FROM Awards
		ORDER BY 2
	if @FieldIndex = 2
		SELECT * FROM Awards
		ORDER BY 3
end
else if @SortStep = 2
begin
	if @FieldIndex = 0
		SELECT * FROM Awards
		ORDER BY 1 DESC
	if @FieldIndex = 1
		SELECT * FROM Awards
		ORDER BY 2 DESC
	if @FieldIndex = 2
		SELECT * FROM Awards
		ORDER BY 3 DESC
end

-------------------------------------
CREATE PROCEDURE UpdateAward
	@AwardID INT,
	@Title NVARCHAR(50),
	@Description NVARCHAR(250)
AS
UPDATE Awards 
	SET Title = @Title,
		[Description] = @Description
	WHERE ID = @AwardID