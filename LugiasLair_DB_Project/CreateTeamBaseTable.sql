--USE PokemonVGC;
--DROP TABLE IF EXISTS TeamFull;
--DROP TABLE IF EXISTS TeamBase;

CREATE TABLE TeamBase
(
teamBaseID INT NOT NULL IDENTITY 
	CONSTRAINT PK_TeamFull PRIMARY KEY,
teamBaseName NVARCHAR (30),
userID INT NOT NULL,
pokemonOneID INT NOT NULL,
pokemonTwoID INT NOT NULL,
pokemonThreeID INT NOT NULL,
pokemonFourID INT NOT NULL,
pokemonFiveID INT NOT NULL,
pokemonSixID INT NOT NULL,
teamPublic INT
);
GO
/*
ALTER TABLE TeamBase
	ADD CONSTRAINT FK_Pokemon_ID_One
	FOREIGN KEY (pokemonOneID)
	REFERENCES Pokemon(pokemonID);
	GO

ALTER TABLE TeamBase
	ADD CONSTRAINT FK_Pokemon_ID_Two
	FOREIGN KEY (pokemonTwoID)
	REFERENCES Pokemon(pokemonID);
	GO

ALTER TABLE TeamBase
	ADD CONSTRAINT FK_Pokemon_ID_Three
	FOREIGN KEY (pokemonThreeID)
	REFERENCES Pokemon(pokemonID);
	GO

ALTER TABLE TeamBase
	ADD CONSTRAINT FK_Pokemon_ID_Four
	FOREIGN KEY (pokemonFourID)
	REFERENCES Pokemon(pokemonID);
	GO

ALTER TABLE TeamBase
	ADD CONSTRAINT FK_Pokemon_ID_Five
	FOREIGN KEY (pokemonFiveID)
	REFERENCES Pokemon(pokemonID);
	GO

ALTER TABLE TeamBase
	ADD CONSTRAINT FK_Pokemon_ID_Six
	FOREIGN KEY (pokemonSixID)
	REFERENCES Pokemon(pokemonID);
	GO

ALTER TABLE TeamBase
	ADD CONSTRAINT FK_User_ID
	FOREIGN KEY (userID)
	REFERENCES VGCPlayer(userID);
	GO

SELECT * FROM TeamBase;
GO

*/