--USE PokemonVGC;

--DROP TABLE IF EXISTS PictureSprite;

CREATE TABLE PictureSprite
(
picSpriteID INT NOT NULL IDENTITY
	CONSTRAINT PK_PictureSprite PRIMARY KEY,
pokemonID INT NOT NULL,
picSpriteName NVARCHAR(40) NOT NULL, 
picSpriteFileName NVARCHAR (100),
picSpriteData VARBINARY (max)
);
GO
/*
ALTER TABLE PictureSprite
	ADD CONSTRAINT FK_Pokemon_ID_Sprite
	FOREIGN KEY (pokemonID)
	REFERENCES Pokemon(pokemonID);

SELECT * FROM PictureSprite;
*/