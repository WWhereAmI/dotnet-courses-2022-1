USE FilmAwards

GO

--Filling Awards table
INSERT INTO Awards (Title, [Description]) VALUES 
	('Oscar. Best male role','BEST PERFORMANCE BY AN ACTOR IN A LEADING ROLE'),
	('Oscar. Best female role','BEST PERFORMANCE BY AN ACTRESS IN A LEADING ROLE'),
	('Oscar. Best supporting actor','BEST PERFORMANCE BY AN ACTOR IN A SUPPORTING ROLE'),
	('Oscar. Best supporting actress','BEST PERFORMANCE BY AN ACTRESS IN A SUPPORTING ROLE'),
	('Oscar. Best director','BEST ACHIEVEMENT IN DIRECTING'),
	('GG. Best male role (DRAMA)','BEST PERFORMANCE BY AN ACTOR IN A MOTION PICTURE - DRAMA'),
	('GG. Best female role (DRAMA)','BEST PERFORMANCE BY AN ACTRESS IN A MOTION PICTURE - DRAMA'),
	('GG. Best supporting actor','BEST PERFORMANCE BY AN ACTOR IN A SUPPORTING ROLE IN A MOTION PICTURE'),
	('GG. Best supporting actress','BEST PERFORMANCE BY AN ACTRESS IN A SUPPORTING ROLE IN A MOTION PICTURE'),
	('GG. Best Director','BEST DIRECTOR - MOTION PICTURE'),
	('MTV. Breakthough of the year','BREAKTHROUGH PERFORMANCE'),
	('MTV. Best comedia role','BEST COMEDIC PERFORMANCE'),
	('MTV. Best villain','BEST VILLAIN'),
	('MTV. Best kiss','BEST KISS'),
	('MTV. Best male role','BEST MALE PERFORMANCE'),
	('MTV. Best female role','BEST FEMALE PERFORMANCE'),
	('GG. Best female role (MUSICAL OR COMEDY)','BEST PERFORMANCE BY AN ACTRESS IN A MOTION PICTURE - MUSICAL OR COMEDY'),
	('GG. Best male role (MUSICAL OR COMEDY)','BEST PERFORMANCE BY AN ACTOR IN A MOTION PICTURE - MUSICAL OR COMEDY')

	
--Filling Users table
INSERT INTO Users(FirstName,LastName,BithDate) VALUES
	('Matthew','McConaughey','1969-11-04T00:00:00'),
	('Cate','Blanchett','1969-05-14T00:00:00'),
	('Jared','Leto','1971-12-26T00:00:00'),
	('Jennifer','Lawrence','1990-08-15T00:00:00'),
	('Alfonso',N'Cuar\u00F3n','1961-11-28T00:00:00'),
	('Eddie','Redmayne','1982-01-06T00:00:00'),
	('J.K.','Simmons','1955-01-09T00:00:00'),
	('Leonardo','DiCaprio','1974-11-11T00:00:00'),
	('Alejandro',N'Gonz\u00E1lez I\u00F1\u00E1rritu','1963-08-15T00:00:00'),
	('Rami','Malek','1981-05-12T00:00:00'),
	('Tom','Hiddleston','1981-02-09T00:00:00'),
	('Ryan','Gosling','1980-11-12T00:00:00'),
	('Jim','Carrey','1962-01-17T00:00:00'),
	('Joaquin','Phoenix','1974-10-28T00:00:00')

--Filling UserAwards table
INSERT INTO UserAwards(UserID, AwardID) VALUES
	((SELECT ID FROM Users WHERE FirstName = 'Matthew' AND LastName = 'McConaughey'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Matthew' AND LastName = 'McConaughey'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (DRAMA)')),
	((SELECT ID FROM Users WHERE FirstName = 'Matthew' AND LastName = 'McConaughey'),(SELECT ID FROM Awards WHERE Title = 'MTV. Breakthough of the year')),
	((SELECT ID FROM Users WHERE FirstName = 'Cate' AND LastName = 'Blanchett'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best female role')),
	((SELECT ID FROM Users WHERE FirstName = 'Cate' AND LastName = 'Blanchett'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best supporting actress')),
	((SELECT ID FROM Users WHERE FirstName = 'Cate' AND LastName = 'Blanchett'),(SELECT ID FROM Awards WHERE Title = 'GG. Best female role (DRAMA)')),
	((SELECT ID FROM Users WHERE FirstName = 'Cate' AND LastName = 'Blanchett'),(SELECT ID FROM Awards WHERE Title = 'GG. Best supporting actress')),
	((SELECT ID FROM Users WHERE FirstName = 'Jared' AND LastName = 'Leto'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best supporting actor')),
	((SELECT ID FROM Users WHERE FirstName = 'Jared' AND LastName = 'Leto'),(SELECT ID FROM Awards WHERE Title = 'GG. Best supporting actor')),
	((SELECT ID FROM Users WHERE FirstName = 'Jennifer' AND LastName = 'Lawrence'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best female role')),
	((SELECT ID FROM Users WHERE FirstName = 'Jennifer' AND LastName = 'Lawrence'),(SELECT ID FROM Awards WHERE Title = 'GG. Best supporting actress')),
	((SELECT ID FROM Users WHERE FirstName = 'Alfonso' AND LastName = N'Cuar\u00F3n'),(SELECT ID FROM Awards WHERE Title = 'GG. Best Director')),
	((SELECT ID FROM Users WHERE FirstName = 'Alfonso' AND LastName = N'Cuar\u00F3n'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best director')),
	((SELECT ID FROM Users WHERE FirstName = 'Eddie' AND LastName = 'Redmayne'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Eddie' AND LastName = 'Redmayne'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (DRAMA)')),
	((SELECT ID FROM Users WHERE FirstName = 'J.K.' AND LastName = 'Simmons'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best supporting actor')),
	((SELECT ID FROM Users WHERE FirstName = 'J.K.' AND LastName = 'Simmons'),(SELECT ID FROM Awards WHERE Title = 'GG. Best supporting actor')),
	((SELECT ID FROM Users WHERE FirstName = 'Leonardo' AND LastName = 'DiCaprio'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Leonardo' AND LastName = 'DiCaprio'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Leonardo' AND LastName = 'DiCaprio'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (DRAMA)')),
	((SELECT ID FROM Users WHERE FirstName = 'Leonardo' AND LastName = 'DiCaprio'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (MUSICAL OR COMEDY)')),
	((SELECT ID FROM Users WHERE FirstName = 'Alejandro' AND LastName = N'Gonz\u00E1lez I\u00F1\u00E1rritu'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best director')),
	((SELECT ID FROM Users WHERE FirstName = 'Alejandro' AND LastName = N'Gonz\u00E1lez I\u00F1\u00E1rritu'),(SELECT ID FROM Awards WHERE Title = 'GG. Best Director')),
	((SELECT ID FROM Users WHERE FirstName = 'Rami' AND LastName = 'Malek'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Rami' AND LastName = 'Malek'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (DRAMA)')),
	((SELECT ID FROM Users WHERE FirstName = 'Tom' AND LastName = 'Hiddleston'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best villain')),
	((SELECT ID FROM Users WHERE FirstName = 'Ryan' AND LastName = 'Gosling'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best kiss')),
	((SELECT ID FROM Users WHERE FirstName = 'Ryan' AND LastName = 'Gosling'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (MUSICAL OR COMEDY)')),
	((SELECT ID FROM Users WHERE FirstName = 'Jim' AND LastName = 'Carrey'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best comedia role')),
	((SELECT ID FROM Users WHERE FirstName = 'Jim' AND LastName = 'Carrey'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best villain')),
	((SELECT ID FROM Users WHERE FirstName = 'Jim' AND LastName = 'Carrey'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Jim' AND LastName = 'Carrey'),(SELECT ID FROM Awards WHERE Title = 'MTV. Best kiss')),
	((SELECT ID FROM Users WHERE FirstName = 'Jim' AND LastName = 'Carrey'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (MUSICAL OR COMEDY)')),
	((SELECT ID FROM Users WHERE FirstName = 'Jim' AND LastName = 'Carrey'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (DRAMA)')),
	((SELECT ID FROM Users WHERE FirstName = 'Joaquin' AND LastName = 'Phoenix'),(SELECT ID FROM Awards WHERE Title = 'Oscar. Best male role')),
	((SELECT ID FROM Users WHERE FirstName = 'Joaquin' AND LastName = 'Phoenix'),(SELECT ID FROM Awards WHERE Title = 'GG. Best male role (MUSICAL OR COMEDY)'))


SELECT UA.UserID, U.FirstName, U.LastName, U.BithDate, UA.AwardID,  A.Title, A.[Description]
	FROM UserAwards AS UA 
		JOIN Users AS U ON UA.UserID = U.ID
		JOIN Awards AS A ON UA.AwardID = A.ID
