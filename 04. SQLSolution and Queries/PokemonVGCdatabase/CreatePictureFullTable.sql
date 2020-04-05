USE PokemonVGC;

DROP TABLE IF EXISTS PictureFull;

CREATE TABLE PictureFull
(
picFullID INT NOT NULL IDENTITY
	CONSTRAINT PK_PictureFull PRIMARY KEY,
pokemonID INT NOT NULL,
picFullName NVARCHAR(40) NOT NULL, 
picFullFileName NVARCHAR (100),
picFullData VARBINARY (max)
);
ALTER TABLE PictureFull
	ADD CONSTRAINT FK_Pokemon_ID_Full
	FOREIGN KEY (pokemonID)
	REFERENCES Pokemon(pokemonID);

SELECT * FROM PictureFull;