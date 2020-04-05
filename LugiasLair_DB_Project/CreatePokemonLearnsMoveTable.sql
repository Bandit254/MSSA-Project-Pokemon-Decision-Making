--USE PokemonVGC;

--DROP TABLE IF EXISTS PokemonLearnsMove;

CREATE TABLE PokemonLearnsMove
(
pkmnMoveID INT NOT NULL IDENTITY
	CONSTRAINT PK_PokemonLearnsMove PRIMARY KEY,
pokemonID INT NOT NULL,
moveID INT NOT NULL,
);
GO
/*
ALTER TABLE PokemonLearnsMove
	ADD CONSTRAINT FK_Pokemon_Move
	FOREIGN KEY (pokemonID)
	REFERENCES Pokemon(pokemonID);
GO
ALTER TABLE PokemonLearnsMove
	ADD CONSTRAINT FK_Move_Pokemon
	FOREIGN KEY (moveID)
	REFERENCES PokemonMove(moveID);
	GO
SELECT * FROM PokemonLearnsMove;
GO
*/