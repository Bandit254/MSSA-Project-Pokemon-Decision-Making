--USE PokemonVGC;

--DROP TABLE IF EXISTS VGCPlayer;

CREATE TABLE VGCPlayer
(
userID INT NOT NULL IDENTITY
	CONSTRAINT PK_VGCPlayer PRIMARY KEY,
userName NVARCHAR (50),
userEmail NVARCHAR (75),
userPassword NVARCHAR (256)
);
GO
/*
SELECT * FROM VGCPlayer;

INSERT INTO VGCPlayer (userName, userEmail, userPassword)
VALUES
('5Cerberus4', 'zachsilvis@gmail.com', 'pokemonIsTheBest');

SELECT * FROM VGCPlayer;
*/