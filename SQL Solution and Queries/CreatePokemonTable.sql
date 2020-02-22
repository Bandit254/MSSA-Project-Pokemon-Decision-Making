USE PokemonVGC;

DROP TABLE IF EXISTS Pokemon; 

CREATE TABLE Pokemon
(
pokemonID INT NOT NULL IDENTITY
	CONSTRAINT PK_Pokemon PRIMARY KEY,
pokemonNumber INT,
pokemonName NVARCHAR (50),
pokemonTypeOne INT,
pokemonTypeTwo INT,
pokemonStatTotal INT,
pokemonHitPoints INT,
pokemonAttack INT,
pokemonDefense INT,
pokemonSpecialAttack INT,
pokemonSpecialDefense INT,
pokemonSpeed INT, 
);

SELECT * FROM Pokemon;

INSERT INTO Pokemon (pokemonNumber, pokemonName, pokemonTypeOne,
pokemonTypeTwo, pokemonStatTotal, pokemonHitPoints, pokemonAttack, 
pokemonDefense, pokemonSpecialAttack, pokemonSpecialDefense, pokemonSpeed)
VALUES
(1, 'Bulbasaur',5,8,318,45,49,49,65,65,45),
(2, 'Ivysaur',5,8,405,60,62,63,80,80,60),
(3, 'Venusaur',5,8,525,80,82,83,100,100,80),
(3, 'Mega Venusaur',5,8,625,80,100,123,122,120,80),
(4, 'Charmander',2,NULL,309,39,52,43,60,50,65),
(5, 'Charmeleon',2,NULL,405,58,64,58,80,65,80),
(6, 'Charizard',2,10,534,78,84,78,109,85,100),
(6, 'Mega Charizard X',2,15,634,78,130,111,130,85,100),
(6, 'Mega Charizard Y',2,10,634,78,104,78,159,115,100),
(7, 'Squirtle',3,NULL,314,44,48,65,50,64,43),
(8, 'Wartortle',3,NULL,405,59,63,80,65,80,58),
(9, 'Blastoise',3,NULL,530,79,83,100,85,105,78),
(9, 'Mega Blastoise',3,NULL,630,79,103,120,135,115,78);

SELECT * FROM Pokemon;



