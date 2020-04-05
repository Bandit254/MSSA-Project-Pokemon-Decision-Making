USE PokemonVGC;

DROP TABLE IF EXISTS PictureTrainerSprite;

CREATE TABLE PictureTrainerSprite
(
picTrainerSpriteID INT NOT NULL IDENTITY
	CONSTRAINT PK_PictureTrainerSprite PRIMARY KEY,
pokemonID INT NOT NULL,
picTrainerSpriteName NVARCHAR(40) NOT NULL, 
picTrainerSpriteFileName NVARCHAR (100),
picTrainerSpriteData VARBINARY (max)
);

SELECT * FROM PictureTrainerSprite;