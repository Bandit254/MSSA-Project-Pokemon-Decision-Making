--USE PokemonVGC;

--DROP TABLE IF EXISTS PokemonType;

CREATE TABLE PokemonType
(
typeID INT NOT NULL IDENTITY
	CONSTRAINT PK_PokemonType PRIMARY KEY,
typeNumber INT,
typeName NVARCHAR (15),
);
GO
--SELECT * FROM PokemonType;
/*
INSERT INTO PokemonType (typeNumber, typeName)
VALUES
(1, 'Normal'),
(2, 'Fire'),
(3, 'Water'),
(4, 'Electric'),
(5, 'Grass'),
(6, 'Ice'),
(7, 'Fighting'),
(8, 'Poison'),
(9, 'Ground'),
(10, 'Flying'),
(11, 'Psychic'),
(12, 'Bug'),
(13, 'Rock'),
(14, 'Ghost'),
(15, 'Dragon'),
(16, 'Dark'),
(17, 'Steel'),
(18, 'Fairy');

SELECT * FROM PokemonType;

*/