USE PokemonVGC;

DROP TABLE IF EXISTS TeamFull;

CREATE TABLE TeamFull
(
teamFullID INT NOT NULL IDENTITY 
	CONSTRAINT PK_TeamFull PRIMARY KEY,
teamFullName NVARCHAR (30),
userID INT,
pokemonOneID INT,
pokemonTwoID INT,
pokemonThreeID INT,
pokemonFourID INT,
pokemonFiveID INT,
pokemonSixID INT
);

SELECT * FROM TeamFull;