USE PokemonVGC;

DROP TABLE IF EXISTS Nature;

CREATE TABLE Nature
(
natureID INT NOT NULL IDENTITY
	CONSTRAINT PK_Nature PRIMARY KEY,
natureName NVARCHAR (15),
natureIncreses NVARCHAR (20),
natureDecreases NVARCHAR (20),
natureBerryDislike NVARCHAR (10),
);

INSERT INTO Nature (natureName, natureIncreses, natureDecreases, natureBerryDislike)
VALUES
('Adamant', 'Attack', 'Sp. Atk', 'Dry'),
('Bashful', 'Neutral', 'Neutral', 'None'),
('Bold', 'Defense', 'Attack', 'Spicy'),
('Brave', 'Attack', 'Speed', 'Sweet'),
('Calm', 'Sp. Def', 'Attack', 'Spicy'),
('Careful', 'Sp. Def', 'Sp. Atk', 'Dry'),
('Docile', 'Neutral', 'Neutral', 'None'),
('Gentle', 'Sp. Def', 'Defense', 'Sour'),
('Hardy', 'Neutral', 'Neutral', 'None'),
('Hasty', 'Speed', 'Defense', 'Sour'),
('Impish', 'Defense', 'Sp. Atk', 'Dry'),
('Jolly', 'Speed', 'Sp. Atk', 'Dry'),
('Lax', 'Defense', 'Sp. Def', 'Bitter'),
('Lonely', 'Attack', 'Defense', 'Sour'),
('Mild', 'Sp. Atk', 'Defense', 'Sour'),
('Modest', 'Sp. Atk', 'Attack', 'Spicy'),
('Naive', 'Speed', 'Sp. Def', 'Bitter'),
('Naughty', 'Attack', 'Sp. Def', 'Bitter'),
('Quiet', 'Sp. Atk', 'Speed', 'Sweet'),
('Quirky', 'Neutral', 'Neutral', 'None'),
('Rash', 'Sp. Atk', 'Sp. Def', 'Bitter'),
('Relaxed', 'Defense', 'Speed', 'Sweet'),
('Sassy', 'Sp. Def', 'Speed', 'Sweet'),
('Serious', 'Neutral', 'Neutral', 'None'),
('Timid', 'Speed', 'Attack', 'Spicy');

SELECT * FROM Nature;