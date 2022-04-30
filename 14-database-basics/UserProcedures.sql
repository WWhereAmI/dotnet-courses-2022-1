--Procedures for User
USE FilmAwards

------------------------------------
CREATE PROCEDURE AddUser
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(50),
	@BirthDate DATE
AS
INSERT INTO Users(FirstName, LastName, BithDate)
	VALUES(@FirstName, @LastName, @BirthDate)

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
SELECT * FROM Users
	WHERE ID = @UserID

-------------------------------------
CREATE PROCEDURE GetUserAwards
	@UserID INT
AS
SELECT A.Title FROM UserAwards AS UA
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
	@AwardID INT
AS
DELETE FROM UserAwards 
	WHERE AwardID = @AwardID

-------------------------------------
CREATE PROCEDURE OrderUserByFieldASC
	@FieldIndex INT
AS
if @FieldIndex = 1
	SELECT * FROM Users
	ORDER BY 1
if @FieldIndex = 2
	SELECT * FROM Users
	ORDER BY 2
if @FieldIndex = 3
	SELECT * FROM Users
	ORDER BY 3
if @FieldIndex = 4
	SELECT * FROM Users
	ORDER BY 4

-------------------------------------
CREATE PROCEDURE OrderUserByFieldDESC
	@FieldIndex INT
AS
if @FieldIndex = 1
	SELECT * FROM Users
	ORDER BY 1 DESC
if @FieldIndex = 2
	SELECT * FROM Users
	ORDER BY 2 DESC
if @FieldIndex = 3
	SELECT * FROM Users
	ORDER BY 3 DESC
if @FieldIndex = 4
	SELECT * FROM Users
	ORDER BY 4 DESC


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