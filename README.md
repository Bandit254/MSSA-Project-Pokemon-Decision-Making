# MSSA Project: Pokémon Decision Making
The Microsoft Software and Systems Academy (MSSA) is a program designed to teach transitioning servicemembers and veterans the skills necessary for moving into the IT field. I am attending the MSSA program for Cloud Application Development (CAD) hosted by Embry-Riddle Aeronautical University (ERAU) in San Diego, CA. All students are required to complete a personal project as part of the 19-week course. This repository hosts all of the files and documents necessary for the completion of my project.

## Project Motivation / Background
I have been playing Pokémon on-and-off since 5th grade. I came to the game late compared to my friends who were immediately swept up by the first generation of games in the late 1990s, but it has stuck with me longer.

While most people are familiar with the trading cards, the anime series, and the story mode of the Pokémon video games, the competitive scene for Pokémon has been relatively unknown until recently. The rules for competitive Pokémon battles are far more complex than the regular story mode,  which has the effect of turning a simple children's game into a difficult game of strategy and information management. One former world champion describes the  competitive version of Pokémon as a mixture of chess, poker, and rock-paper-scissors.

While the most recent generation of games (Sword and Shield, the 8th Generation) have made it far easier to build competitively viable Pokémon teams, that has not made competitive battles any easier. Each Pokémon has a wide range of moves, stats, abilities, and items that players must consider in order to be successful, and with more players than ever eager to learn the competitive scene it is becoming more difficult to find and exploit an advantage in the game. 

Therefore, the motivation behind this project is to build a web application that aids players as they analyze Pokémon individually, build teams, and prepare for battles against their opponents. This application will enable players to examine combinations and interactions that they might otherwise miss (or not have time to calculate for themselves). It will also help players keep track of the information they have revealed to their opponents and vice versa during in the course of a competitive match.

For more information on the background and motivation behind this project, see the paper and presentation in folder "01. Project Proposal and Presentation."

## Entity Relationship Diagrams
The picture below is my initial entity relationship diagram for the database I will build to support my application. I used Draw.io. The JPEG and PDF version of the ERD can also be found in folder "02. Database Entity Relationship Diagrams."

![ERD](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/02.%20Database%20Entity%20Relationship%20Diagrams/CADProject%20-%2020200209%20-%20ZSilvis%20-%20ERD.jpg)

## Project Data
There are many sources for Pokémon data, and there is a lot of it. The folder "03. Project Data (Excel and CSV" will contain all of the raw data that I need to complete this project. Although the current competitive rules only allows for a subset of the 400 Pokémon available in Sword and Shield to participate in official battles, I want to include data on all Pokémon from all generations in order to make the application accommodating to future rules changes and new game releases. 

## Building the Database
I will use T-SQL and Microsoft SQL Server to build the primary database for this project. The folder "04. SQL Solution and Queries" contains all of the queries I have written to build the database (so far).

## Website Wire Frames
Below are a few of the wire frame designs I have made for the application's website. These are not all of the pages I have designed, nor are they final designs. I used [https://pencil.evolus.vn/](https://pencil.evolus.vn/) to create the wire frames. I also included a diagram that I sketched in OneNote. 

![Content Hub](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/ContentHubPage%20%2823FEB2020%29.jpg)
 
 ![Create a Team](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/CreateTeamPage%20%2823FEB2020%29.jpg)

![Analyze Team](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/AnalyzeTeamPage%20%2823FEB2020%29.jpg)

## Source Code From Other Projects
Although I have not yet incorporated course from other projects, there are two projects that I am likely to draw upon: the Pokémon Showdown battle simulator and the Veekun Project. Both projects' source code is stored in folders XX and YY, respectively. 

## User Stories
The following are some of the user stories that are guiding my design:

 1.  As a new / inexperienced Pokémon player, I want a program that will help me learn what moves, stats, abilities, items and types each Pokémon has available to them so that I can make better selections for my teams and so that I don’t have to memories all of the possible type/move/stat/ability/item combinations.
 2.  As a player who has played Pokémon games for a long time but has very little experience with competitive Pokémon battles, I need a program that will help me analyze whether or not the Pokémon teams I have built playing the story mode are competitively viable. I also need to be able to learn how the moves I normally select for my Pokémon will need to change in order to be successful in a competitive Pokémon battle.
 3.  As a competitive Pokémon battler with a short history in the game, I need a program that will help me develop an intuition for the most likely 4-Pokémon team that my opponent will select to face me so that I can make the best 4-Pokémon of my own. I need to be able to see all of the possible combinations available and have the program help me determine which team combinations are best.
 4. As an experienced competitive Pokémon battler, I need a program that provides me with a way to easily customize Pokémon and teams so that I can quickly prototype new teams and stay ahead of my opponents. I want to be able to save the team and Pokémon combinations that I create so that I can easily refer to them in the future. I also need a program that will provide me with detailed statistics on the most common Pokémon/moves/abilities/items/types in use across the entire competitive scene so that I can plan my teams to be successful against those combinations.
 5. As Pokémon player engaged in a Pokémon battle using competitive rules (whether an actual competition or a friendly/casual match), I need a program that will help me track the information that I have revealed to my opponent and that my opponent has revealed to me so that I can make more precise decisions in battle without having to memorize everything that has occurred in a battle. I would also like a way to store and display my record in all matches and the teams I used in those matches.
## Use Cases
based on the user stories, I have developed this initial list of use cases:
 1. <![endif]--> Given a new user to the program, when the new user selects the option to create an account, then the program will provide the fields and options necessary for account creation and store the user’s information in their new profile.
 2. <![endif]--> Given a returning user, when the user selects the option to log-in, then the program will verify the user’s credentials and (if valid) allow the user access to the program.
 3. <![endif]--> Given user input about one or more of the following criteria ­­-- Pokémon name, Pokémon number, type, move(s), ability, stats -- when the user chooses the option to search based on those criteria then the system shall display all Pokémon that meet the user’s criteria.

<!--stackedit_data:
eyJoaXN0b3J5IjpbMTI1NDQxMjg3NiwxNTIyNzQ0MTU4XX0=
-->