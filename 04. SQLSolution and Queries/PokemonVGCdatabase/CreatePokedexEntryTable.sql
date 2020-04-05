USE PokemonVGC;

DROP TABLE IF EXISTS PokedexEntry;

CREATE TABLE PokedexEntry
(
pokedexEntryID INT NOT NULL IDENTITY
	CONSTRAINT PK_PokedexEntry PRIMARY KEY,
pokemonID INT NOT NULL,
pokedexEntry NVARCHAR (256)
);

ALTER TABLE PokedexEntry
	ADD CONSTRAINT FK_Pokemon_ID
	FOREIGN KEY (pokemonID)
	REFERENCES Pokemon(pokemonID);

SELECT * FROM PokedexEntry;