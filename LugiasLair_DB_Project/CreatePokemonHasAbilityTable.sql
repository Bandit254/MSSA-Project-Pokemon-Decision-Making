--USE PokemonVGC;

--DROP TABLE IF EXISTS PokemonHasAbility;

CREATE TABLE PokemonHasAbility
(
pkmnAbilityID INT NOT NULL IDENTITY
	CONSTRAINT PK_PokemonHasAbility PRIMARY KEY,
pokemonID INT NOT NULL,
abilityID INT NOT NULL,
hiddenAbility INT NOT NULL
);
GO
/*
ALTER TABLE PokemonHasAbility
	ADD CONSTRAINT FK_Pokemon_Ability
	FOREIGN KEY (pokemonID)
	REFERENCES Pokemon(pokemonID);
GO
ALTER TABLE PokemonHasAbility
	ADD CONSTRAINT FK_Ability_Pokemon
	FOREIGN KEY (abilityID)
	REFERENCES Ability(abilityID);
GO
SELECT * FROM PokemonHasAbility;
GO
*/