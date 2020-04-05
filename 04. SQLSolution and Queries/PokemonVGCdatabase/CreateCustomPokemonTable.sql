USE PokemonVGC;

DROP TABLE IF EXISTS CustomPokemon;

CREATE TABLE CustomPokemon
(
customPokemonID INT NOT NULL IDENTITY
	CONSTRAINT PK_CustomPokemon PRIMARY KEY,
pokemonID INT NOT NULL,
pokedexEntryID INT NOT NULL,
userID INT NOT NULL,
pokemonNickname NVARCHAR (20),
pkmnTypeOneID INT NOT NULL,
pkmnTypeTwoID INT,

moveOneID INT,
moveTwoID INT,
moveThreeID INT,
moveFourID INT,

abilityID INT,
natureID INT,
characteristicID INT,
itemID INT,

hitPointIV INT,
attackIV INT,
defenseIV INT,
spAttackIV INT,
spDefenseIV INT,
speedIV INT,

hitPointEV INT,
attackEV INT,
defenseEV INT,
spAttackEV INT,
spDefenseEV INT,
speedEV INT,

overallHitPoints INT,
overallAttack INT,
overallDefense INT,
overallSpAttack INT,
overallSpDefense INT,
overallSpeed INT
);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_Pokemon_CustomPokemon
	FOREIGN KEY (pokemonID)
	REFERENCES Pokemon(pokemonID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_PokedexEntry_CustomPokemon
	FOREIGN KEY (pokedexEntryID)
	REFERENCES PokedexEntry(pokedexEntryID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_VGCPlayer_CustomPokemon
	FOREIGN KEY (userID)
	REFERENCES VGCPlayer(userID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_TypeOne_CustomPokemon
	FOREIGN KEY (pkmnTypeOneID)
	REFERENCES PokemonType(typeID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_TypeTwo_CustomPokemon
	FOREIGN KEY (pkmnTypeTwoID)
	REFERENCES PokemonType(typeID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_MoveOne_CustomPokemon
	FOREIGN KEY (moveOneID)
	REFERENCES PokemonMove(moveID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_MoveTwo_CustomPokemon
	FOREIGN KEY (moveTwoID)
	REFERENCES PokemonMove(moveID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_MoveThree_CustomPokemon
	FOREIGN KEY (moveThreeID)
	REFERENCES PokemonMove(moveID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_MoveFour_CustomPokemon
	FOREIGN KEY (moveFourID)
	REFERENCES PokemonMove(moveID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_Ability_CustomPokemon
	FOREIGN KEY (abilityID)
	REFERENCES Ability(abilityID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_Nature_CustomPokemon
	FOREIGN KEY (natureID)
	REFERENCES Nature(natureID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_Characteristic_CustomPokemon
	FOREIGN KEY (characteristicID)
	REFERENCES Characteristic(characteristicID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT FK_HeldItem_CustomPokemon
	FOREIGN KEY (itemID)
	REFERENCES HeldItem(itemID);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_HitPointIV_CustomPokemon
	CHECK (31>=hitPointIV AND hitPointIV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_AttackIV_CustomPokemon
	CHECK (31>=attackIV AND attackIV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_DefenseIV_CustomPokemon
	CHECK (31>=defenseIV AND defenseIV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpAttackIV_CustomPokemon
	CHECK (31>=spAttackIV AND spAttackIV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpDefenseIV_CustomPokemon
	CHECK (31>=spDefenseIV AND spDefenseIV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpeedIV_CustomPokemon
	CHECK (31>=speedIV AND speedIV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpreadEVs_CustomPokemon
	CHECK ((hitPointEV+attackEV+defenseEV+spAttackEV+spDefenseEV+speedEV)<=510);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_HitPointEVs_CustomPokemon
	CHECK (255>=hitPointEV AND hitPointEV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_AttackEVs_CustomPokemon
	CHECK (255>=attackEV AND attackEV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_DefenseEVs_CustomPokemon
	CHECK (255>=defenseEV AND defenseEV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpAttackEVs_CustomPokemon
	CHECK (255>=spAttackEV AND spAttackEV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpDefenseEVs_CustomPokemon
	CHECK (255>=spDefenseEV AND spDefenseEV>=0);

ALTER TABLE CustomPokemon
	ADD CONSTRAINT CHK_SpeedEVs_CustomPokemon
	CHECK (255>=speedEV AND speedEV>=0);

SELECT * FROM CustomPokemon;