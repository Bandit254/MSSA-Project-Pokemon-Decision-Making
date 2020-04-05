--USE PokemonVGC;

--DROP TABLE IF EXISTS TeamBattle;
--DROP TABLE IF EXISTS TeamVGC;

CREATE TABLE TeamVGC
(
teamVGCID INT NOT NULL IDENTITY
	CONSTRAINT PK_TeamVGC PRIMARY KEY,
userID INT NOT NULL,
teamBaseID INT NOT NULL,
pkmnVGCOneID INT NOT NULL,
pkmnVGCTwoID INT NOT NULL,
pkmnVGCThreeID INT NOT NULL,
pkmnVGCFourID INT NOT NULL
);
GO
/*
ALTER TABLE TeamVGC
	ADD CONSTRAINT FK_User_ID_VGC
	FOREIGN KEY (userID)
	REFERENCES VGCPlayer(userID);
	GO
ALTER TABLE TeamVGC
	ADD CONSTRAINT FK_Pokemon_ID_One_VGC
	FOREIGN KEY (pkmnVGCOneID)
	REFERENCES Pokemon(pokemonID);
	GO
ALTER TABLE TeamVGC
	ADD CONSTRAINT FK_Pokemon_ID_Two_VGC
	FOREIGN KEY (pkmnVGCTwoID)
	REFERENCES Pokemon(pokemonID);
	GO
ALTER TABLE TeamVGC
	ADD CONSTRAINT FK_Pokemon_ID_Three_VGC
	FOREIGN KEY (pkmnVGCThreeID)
	REFERENCES Pokemon(pokemonID);
	GO
ALTER TABLE TeamVGC
	ADD CONSTRAINT FK_Pokemon_ID_Four_VGC
	FOREIGN KEY (pkmnVGCFourID)
	REFERENCES Pokemon(pokemonID);
	GO
SELECT * FROM TeamVGC;
GO

*/