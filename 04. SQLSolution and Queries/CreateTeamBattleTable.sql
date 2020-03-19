USE PokemonVGC;

DROP TABLE IF EXISTS TeamBattle;

CREATE TABLE TeamBattle
(
battleTeamID INT NOT NULL IDENTITY
	CONSTRAINT PK_TeamBattle PRIMARY KEY,
userID INT,
teamFullID INT,
pokemonOneID INT,
pokemonTwoID INT,
pokemonThreeID INT,
pokemonFourID INT
);

SELECT * FROM TeamBattle;