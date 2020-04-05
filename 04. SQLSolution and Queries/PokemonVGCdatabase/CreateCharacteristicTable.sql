USE PokemonVGC;

DROP TABLE IF EXISTS Characteristic;

CREATE TABLE Characteristic
(
characteristicID INT NOT NULL IDENTITY
	CONSTRAINT PK_Characteristic PRIMARY KEY,
characteristicDescription NVARCHAR (35),
benefittingStat NVARCHAR (10),

);

INSERT INTO Characteristic (characteristicDescription, benefittingStat)
VALUES
('Likes to relax', 'HP'),
('Loves to eat', 'HP'),
('Nods off a lot', 'HP'),
('Scatters things often ', 'HP'),
('Takes plenty of siestas', 'HP'),
('A little quick tempered', 'Attack'),
('Likes to fight', 'Attack'),
('Likes to thrash about', 'Attack'),
('Proud of its power', 'Attack'),
('Quick tempered', 'Attack'),
('Capable of taking hits', 'Defense'),
('Good endurance', 'Defense'),
('Good perseverance', 'Defense'),
('Highly persistent', 'Defense'),
('Sturdy body', 'Defense'),
('Highly curious', 'Sp. Atk'),
('Mischievous', 'Sp. Atk'),
('Often lost in thought', 'Sp. Atk'),
('Thoroughly cunning', 'Sp. Atk'),
('Very finicky', 'Sp. Atk'),
('Hates to lose', 'Sp. Def'),
('Somewhat stubborn', 'Sp. Def'),
('Somewhat vain', 'Sp. Def'),
('String willed', 'Sp. Def'),
('Strongly defiant', 'Sp. Def'),
('Alert to sounds', 'Speed'),
('Impetuous and silly', 'Speed'),
('Likes to run', 'Speed'),
('Quick to flee', 'Speed'),
('Smewhat of a clown', 'Speed');

SELECT * FROM Characteristic;