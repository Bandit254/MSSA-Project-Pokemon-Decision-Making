USE PokemonVGC;

DROP TABLE IF EXISTS PokemonMove;

CREATE TABLE PokemonMove
(
moveID INT NOT NULL IDENTITY
	CONSTRAINT PK_PokemonMove PRIMARY KEY,
moveName NVARCHAR (30),
moveType INT,
moveCategory INT,
movePower INT,
moveAccuracy INT,
movePoints INT,
moveEffect NVARCHAR (200),
moveEffectProb INT
);

SELECT * FROM PokemonMove;

INSERT INTO PokemonMove (moveName, movePower, moveAccuracy, movePoints, moveEffect, moveEffectProb)
VALUES
('Accelerock' ,40,100,20, 'User attacks first.', NULL),
('Acrobatics' ,55,100,15, 'Stronger when the user does not have a held item.', NULL),
('Aerial Ace' ,60,100,20, 'Ignores Accuracy and Evasiveness.', NULL),
('Anchor Shot' ,80,100,20, 'The user entangles the target with its anchor chain while attacking. The target becomes unable to flee.', NULL),
('Aqua Jet' ,40,100,20, 'User attacks first.', NULL),
('Aqua Tail' ,90,90,10, '', NULL),
('Arm Thrust' ,15,100,20, 'Hits 2-5 times in one turn.', NULL),
('Assurance' ,60,100,10, 'Power doubles if opponent already took damage in the same turn.', NULL),
('Astonish' ,30,100,15, 'May cause flinching.',30);

SELECT * FROM PokemonMove;
