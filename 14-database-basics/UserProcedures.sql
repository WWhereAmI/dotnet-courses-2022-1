--Procedures for User
USE FilmAwards

------------------------------------
CREATE PROCEDURE AddUser
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(50),
	@BirthDate DATE,
	@NewID INT OUT
AS
INSERT INTO Users(FirstName, LastName, BithDate)
	VALUES(@FirstName, @LastName, @BirthDate)
SET @NewID = SCOPE_IDENTITY()

-------------------------------------
CREATE PROCEDURE RemoveUser
	@UserID INT
AS
DELETE FROM Users WHERE 		
	ID = @UserID

-------------------------------------
CREATE PROCEDURE GetUser
	@UserID INT
AS
SELECT Users.ID, Users.FirstName,Users.LastName, Users.BithDate, Awards.ID, Awards.Title, Awards.[Description] 
	FROM UserAwards RIGHT JOIN Users ON Users.ID = UserAwards.UserID
	LEFT JOIN Awards ON Awards.ID = UserAwards.AwardID
		WHERE Users.ID = @UserID

-------------------------------------
CREATE PROCEDURE GetUserAwards
	@UserID INT
AS
SELECT A.ID, A.Title, A.Description FROM UserAwards AS UA
	JOIN Awards AS A ON UA.AwardID = A.ID
	WHERE UA.UserID = @UserID

-------------------------------------
CREATE PROCEDURE AddUserAward
	@UserID INT,
	@AwardID INT
AS
INSERT INTO UserAwards(UserID, AwardID) 
	VALUES(@UserID, @AwardID)

-------------------------------------
CREATE PROCEDURE RemoveUserAward
	@AwardID INT,
	@UserID INT
AS
DELETE FROM UserAwards 
	WHERE AwardID = @AwardID AND UserID = @UserID

-------------------------------------
CREATE PROCEDURE OrderUserByField
	@FieldIndex INT,
	@SortStep INT
AS
if @SortStep = 1
begin
	if @FieldIndex = 0
		SELECT * FROM Users
		ORDER BY 1
	if @FieldIndex = 1
		SELECT * FROM Users
		ORDER BY 2
	if @FieldIndex = 2
		SELECT * FROM Users
		ORDER BY 3
	if @FieldIndex = 3
		SELECT * FROM Users
		ORDER BY 4
end
else if @SortStep = 2
begin
	if @FieldIndex = 0
		SELECT * FROM Users
		ORDER BY 1 DESC
	if @FieldIndex = 1
		SELECT * FROM Users
		ORDER BY 2 DESC
	if @FieldIndex = 2
		SELECT * FROM Users
		ORDER BY 3 DESC
	if @FieldIndex = 3
		SELECT * FROM Users
		ORDER BY 4 DESC
end

-------------------------------------
CREATE PROCEDURE UpdateUser
	@UserID INT,
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(50),
	@BirthDate DATE
AS
UPDATE Users 
	SET FirstName = @FirstName,
		LastName = @LastName,
		BithDate = @BirthDate
	WHERE ID = @UserID