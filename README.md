# MSSA Project: Pokémon Decision Making
Competitive Pokémon, while based on a children's game, is an extremely complex game that requires both skill and intuition. Competitive matches combine elements from poker, chess, game theory, and an extremely complicated version of rock-paper-scissors (if rock-paper-scissors was played with 18 different implements). This project will build a web application to assist competitive Pokémon players analyze the vast amount choices available to them as they build a team, provide metrics with which to rank their teams, manage the information that they and their opponents have revealed to each other in-game, and generate both unconditional and conditional opponent strategies. These features will help players make better decisions and increase their likelihood of victory. To complete this project, I am relying on the skills I am learning in C#, ASP.NET / MVC, and T-SQL through the MSSA Program.

## Table of Contents
(The table of content will be updated as the project progresses)
 1. [Project Motivation / Background](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#project-motivation--background)
 2. [Entity Relationship Diagram](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#entity-relationship-diagrams)
 3. [Project Data](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#project-data)
 4. [Building the Database](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#building-the-database)
 5. [Website Wire Frames](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#website-wire-frames)
 6. [Outside Source Code](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#source-code-from-other-projects)
 7. [User Stories](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#user-stories)
 8. [Use Cases](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#use-cases)
 9. [Requirements](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#requirements)
 10. [Test Plan](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#test-plan) 
 11. [Prototype](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#prototype)
 12. [Entity Framework and Initial Model Scaffolding](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#entity-framework-and-initial-model-scaffolding)
 13. [Connecting to the DB to Display/Modify Data](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#connecting-to-the-db-to-displaymodify-data)
 14. [Initial Sprint Planning](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#initial-sprint-planning)
 15. [Sprint Reviews](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/11.%20Sprint%20Planning%20and%20Review)
 16. [End-Of-MSSA Test and Requirements Review](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#end-of-mssa-test-and-requirements-review)
 17. [Project Work Backlog](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#project-work-backlog)
 18. [Most Current Source Code (located on dev branch)](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/dev/MSSA-CAD-Project-Lugias-Lair)
 19. [Live Website](https://lugias-lair.azurewebsites.net)

## Project Motivation / Background
I have been playing Pokémon on-and-off since 5th grade. I came to the game late compared to my friends who were immediately swept up by the first generation of games in the late 1990s, but it has stuck with me longer.

While most people are familiar with the trading cards, the anime series, and the story mode of the Pokémon video games, the competitive scene for Pokémon has been relatively unknown until recently. The rules for competitive Pokémon battles are far more complex than the regular story mode,  which has the effect of turning a simple children's game into a difficult game of strategy and information management. One former world champion describes the  competitive version of Pokémon as a mixture of chess, poker, and rock-paper-scissors.

While the most recent generation of games (Sword and Shield, the 8th Generation) have made it far easier to build competitively viable Pokémon teams, that has not made competitive battles any easier. Each Pokémon has a wide range of moves, stats, abilities, and items that players must consider in order to be successful, and with more players than ever eager to learn the competitive scene it is becoming more difficult to find and exploit an advantage in the game. 

Therefore, the motivation behind this project is to build a web application that aids players as they analyze Pokémon individually, build teams, and prepare for battles against their opponents. This application will enable players to examine combinations and interactions that they might otherwise miss (or not have time to calculate for themselves). It will also help players keep track of the information they have revealed to their opponents and vice versa during in the course of a competitive match.

*Key Terms:*
The crux of my web application is the analysis and generation of Pokémon teams for competitive matches. As I explain below, a player brings a team of 6 Pokémon to a competitive set. But, during each match within a set a player may only bring 4 of those original 6 Pokémon. Therefore, I make the following distinction:

**Team Base** = The full team of 6 Pokémon.

**Team VGC** = the 4 Pokémon a player selects from the original 6 for each match.

I will endeavor to be consistent in my use of these terms for the sake of clarity.

For more information on the background and motivation behind this project, see the paper and presentation in folder [01. Project Proposal and Presentation.](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/01.%20Project%20Proposal%20and%20Presentation)
![System Phase 1](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/01.%20Project%20Proposal%20and%20Presentation/Phase%201.jpg)

![System Phase 2](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/01.%20Project%20Proposal%20and%20Presentation/Phase%202.jpg)

![System Phase 3](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/01.%20Project%20Proposal%20and%20Presentation/Phase%203.jpg)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Entity Relationship Diagrams
The picture below is my initial entity relationship diagram for the database I will build to support my application. I used Draw.io. The JPEG and PDF version of the ERD can also be found in folder [02. Database Entity Relationship Diagrams.](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/02.%20Database%20Entity%20Relationship%20Diagrams)

![ERD](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/02.%20Database%20Entity%20Relationship%20Diagrams/CADProject%20-%2020200209%20-%20ZSilvis%20-%20ERD.jpg)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Project Data
There are many sources for Pokémon data, and there is a lot of it. The folder [03. Project Data (Excel and CSV)](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/03.%20Project%20Data%20%28Excel%20and%20CSV%29) will contain all of the raw data that I need to complete this project. Although the current competitive rules only allows for a subset of the 400 Pokémon available in Sword and Shield to participate in official battles, I want to include data on all Pokémon from all generations in order to make the application accommodating to future rules changes and new game releases. 

Most of the data I am using is fairly easy to obtain, thanks to sites like [Pokémon Database](https://pokemondb.net/). They present data in web tables that can be copied into Excel, reformatted slightly, and then used to generate a SQL script to insert the data into my actual database. 

However, some data relating to Pokémon are not so easy ingested. For example, it is easy to add a table of all moves available in a Pokémon game, but each Pokémon is only allowed to learn a certain subset of the total move list. There is no logical way to predict or script which Pokémon are allowed to learn which moves; therefore the move list for each individual Pokémon must be displayed from a website such as [Serebii.net](https://serebii.net/), copied into Excel, and then manually mapped to the appropriate Pokémon ID number. Only then can a SQL script be generated to add the Pokémon's move set to the database and ensure that each Pokémon can only be assigned moves that they are allowed to learn.

The same process must be completed for the abilities that Pokémon may possess. Each Pokémon can have between 1 and 3 abilities available to it, some of which may be classified as "hidden" abilities. Both the moves that a Pokémon learns and the abilities they possess require the manual creation of what are called "reverse-lookup" tables to ensure that the Pokémon are appropriately restricted to the correct moves/abilities.

Because creating these reverse-lookup tables is a time-consuming process, it is one of the first items I am added to my Project Work Backlog. In the meantime, my web application will have the "flaw" of allowing Pokémon to learn moves and possess abilities that they otherwise shouldn't. 
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Building the Database
I will use T-SQL and Microsoft SQL Server to build the primary database for this project. The folder [04. SQL Solution and Queries](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/04.%20SQLSolution%20and%20Queries) contains all of the queries I have written to build the database (so far).
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Website Wire Frames
Below are a few of the wire frame designs I have made for the application's website. These are not all of the pages I have designed, nor are they final designs. I used [https://pencil.evolus.vn/](https://pencil.evolus.vn/) to create the wire frames. I also included a diagram that I sketched in OneNote. [05. Website Wire Frame Diagrams](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/05.%20Website%20Wire%20Frame%20Diagrams)

![Content Hub](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/ContentHubPage%20%2823FEB2020%29.jpg)
 
 ![Create a Team](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/CreateTeamPage%20%2823FEB2020%29.jpg)

![Analyze Team](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/AnalyzeTeamPage%20%2823FEB2020%29.jpg)

![Wire Frame Sketch from OneNote](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/05.%20Website%20Wire%20Frame%20Diagrams/Wire%20Frame%20Sketches.pdf)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Source Code From Other Projects
Although I have not yet incorporated course from other projects, there are two projects that I am likely to draw upon: the Pokémon Showdown battle simulator and the Veekun Project. Both projects' source code is stored in folders [XX](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/XX.%20Pokemon%20Showdown%20Source%20Files/pokemon-showdown-master) and [YY](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/YY.%20Veekun%20Project%20Source%20Files/pokedex-master), respectively. 
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## User Stories
The following are some of the user stories that are guiding my design. The full document is located here: [06. User Stories](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/06.%20User%20Stories)

 1.  As a new / inexperienced Pokémon player, I want a program that will help me learn what moves, stats, abilities, items and types each Pokémon has available to them so that I can make better selections for my teams and so that I don’t have to memories all of the possible type/move/stat/ability/item combinations.
 2.  As a player who has played Pokémon games for a long time but has very little experience with competitive Pokémon battles, I need a program that will help me analyze whether or not the Pokémon teams I have built playing the story mode are competitively viable. I also need to be able to learn how the moves I normally select for my Pokémon will need to change in order to be successful in a competitive Pokémon battle.
 3.  As a competitive Pokémon battler with a short history in the game, I need a program that will help me develop an intuition for the most likely 4-Pokémon team that my opponent will select to face me so that I can make the best 4-Pokémon of my own. I need to be able to see all of the possible combinations available and have the program help me determine which team combinations are best.
 4. As an experienced competitive Pokémon battler, I need a program that provides me with a way to easily customize Pokémon and teams so that I can quickly prototype new teams and stay ahead of my opponents. I want to be able to save the team and Pokémon combinations that I create so that I can easily refer to them in the future. I also need a program that will provide me with detailed statistics on the most common Pokémon/moves/abilities/items/types in use across the entire competitive scene so that I can plan my teams to be successful against those combinations.
 5. As Pokémon player engaged in a Pokémon battle using competitive rules (whether an actual competition or a friendly/casual match), I need a program that will help me track the information that I have revealed to my opponent and that my opponent has revealed to me so that I can make more precise decisions in battle without having to memorize everything that has occurred in a battle. I would also like a way to store and display my record in all matches and the teams I used in those matches.
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)
## Use Cases
Based on the user stories, I have developed this initial list of use cases. The documentation is stored in this folder: [07. Use Cases](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/07.%20Use%20Cases)
 1.  Given a new user to the program, when the new user selects the option to create an account, then the program will provide the fields and options necessary for account creation and store the user’s information in their new profile.
 2.  Given a returning user, when the user selects the option to log-in, then the program will verify the user’s credentials and (if valid) allow the user access to the program.
 3.  Given user input about one or more of the following criteria ­­-- Pokémon name, Pokémon number, type, move(s), ability, stats -- when the user chooses the option to search based on those criteria then the system shall display all Pokémon that meet the user’s criteria.
 4.  Given a user’s selection of a specific Pokémon and when the user selects the option of “edit Pokémon”, then the program will allow the user to customize the details of the selected Pokémon and give the user the option to save the changes to that Pokémon for later reference.
 5.  Given user-defined search criteria for existing Pokémon teams -- author’s user ID, Pokémon on the team, etc. -- when the user selects the ”search” option then then program will display all public Pokémon teams that meet the criteria and that other users have saved to the system.
 6.  Given a user-selected set of 6 Pokémon, when the user selects “save” then the system will store the details of that team to the user’s profile. The system will also provide the user an option to make the team publicly searchable by other users.
 7.  Given a Pokémon team selected by the user, when the user chooses the option to “analyze team”, then the program will display the team’s strengths, weaknesses, and overall stat ratings.
 8.  Given a Pokémon team selected by the user, when the user selects the option to “analyze battle team,” then the system will display all possible 4-Pokémon teams from the base 6-Pokémon team, as well as the strengths, weaknesses, and overall stats of each 4-Pokémon team.
 9. Given an opponent’s 6-Pokémon team, when the user selects the option to “analyze conditional base team”, then the system will generate a 6-Pokémon team that has the optimal matchup against the opponent team’s strengths/weaknesses.
 10.  Given both a user’s and an opponent’s 6-Pokémon team, when the user selects “match team selection”, then the system will generate first the opponent’s optimal 4-Pokémon team based on the user’s 6-Pokémon team, and then the system will generate the user’s optimal 4-Pokémon team based on the opponent’s 4-Pokémon team.
 11. Given a user and an opponent competing in a competitive Pokémon battle, when either the user or opponent reveals information about their team (uses a move, displays a particular ability, consumes a specific item), then the system will provide an interactive display to record that information so that the information can be referenced later on in the current battle or in the next battle.

These use-cases are represented by the Use-Case Diagram below:
![Use-Case Diagram](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/07.%20Use%20Cases/CAD%20Project%20Use-Case%20Diagram.jpg)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Requirements
The full list of the system requirements are found in folder [08. Requirements](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/08.%20Requirements), but the major requirements are listed below:

 1. The system shall provide a method to allow users to create accounts
 2. The system shall provide a method to allow users to log in
 3. The system shall provide a method for users to display their account information
 4. The system shall provide a method to update user accounts
 5. The system shall provide a consistent navigation/display experience throughout
 6. The system shall provide a method to for users to share their custom Pokémon and teams
 7. The system shall provide a method for users to search for specific Pokémon
 8. The system shall provide a method to display the standard attributes, or ranges of attributes, available to a specified Pokémon
 9. The system shall provide a method for users to edit and save a custom version of a Pokémon
 10. The system shall provide a method for users to create and save a team of 6-Pokémon
 11. The system shall provide a method for users to search for specific Pokémon teams that have been marked as public
 12. The system shall provide a method for users to analyze the strengths and weaknesses of a 6-Pokémon team
 13. The system shall provide a method for users to observe all of the 4-Pokémon teams that can be generated from a 6-Pokémon team
 14. The system shall provide a method for a user to specify an opponent’s 6-Pokémon team and then generate the user’s optional 6-Pokémon team to use against the opponent
 15.  The system shall provide a method for users to predict which 4-Pokémon team an opponent will use in a battle against the user, and then to generate the optimal 4-Pokémon team to counter the opponent’s expected team
 16. The system shall provide a method for users to track information that has been revealed during battle, both by the user and by the opponent
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Test Plan
Below are the requirements verification and and testing tables for this project. Due to the large number of both requirements and tests, only a portion are included directly in this README; the full tables are located in folder [09. Project Testing](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/09.%20Project%20Testing).

**Requirements Verification Table:**

Requirement ID| Requirement Description | Verification Method | Test ID
--|--|--|--
1 | The system shall provide a method to allow users to create accounts | Demonstration | 1
2 | The system shall provide a method to allow users to log in | Demonstration | 16 
3 | The system shall provide a method for users to display their account information | Demonstration | 22 
4 | The system shall provide a method to update user accounts |  Demonstration| 27 
5 | The system shall provide a consistent navigation/display experience throughout | Inspection/Demonstration | 30 
6| The system shall provide a method to for users to share their custom Pokémon and teams | Demonstration | 37 
7| The system shall provide a method for users to search for specific Pokémon | Demonstration |  40
8| The system shall provide a method to display the standard attributes, or ranges of attributes, available to a specified Pokémon | Demonstration |  48
9 | The system shall provide a method for users to edit and save a custom version of a Pokémon | Demonstration |  56
10 | The system shall provide a method for users to create and save a team of 6- Pokémon | Demonstration |  72
11 | The system shall provide a method for users to search for specific Pokémon teams that have been marked as public |Demonstration  |  79
12 | The system shall provide a method for users to analyze the strengths and weaknesses of a 6- Pokémon team | Demonstration |84 
13 | The system shall provide a method for users to observe all of the 4-Pokémon teams that can be generated from a 6-Pokémon team | Demonstration |  92
14 | The system shall provide a method for a user to specify an opponent’s 6- Pokémon team and then generate the user’s optional 6- Pokémon team to use against the opponent | Demonstration | 95 
15 | The system shall provide a method for users to predict which 4-Pokémon team an opponent will use in a battle against the user, and then to generate the optimal 4-Pokémon team to counter the opponent’s expected team | Demonstration |  97
16 | The system shall provide a method for users to track information that has been revealed during battle, both by the user and by the opponent | Demonstration |  98

**Test Plan Table:**

 Test ID | Requirement ID(s) | Test Procedure | Current Status | Last Time Tested |Build Version
--|--|--|--|--|--
1  | 1 | Integration / Security Test of the Account Creation Function | Not Tested |  |
 2 | 1.1 | Unit Test to ensure users provide a username | Not Tested |  |  
 3 | 1.1.1, 2.1 | Unit Test to ensure a username is not already taken | Not Tested |  |  
 4 |1.2, 4.2  | Unit Test to ensure users provide an email | Not Tested |  |  
 5 |1.2.1, 4.2  | Unit Test to ensure the user's email is a valid email | Not Tested |  |  
 6 |1.2.2, 2.3.1.1, 4.2  | Unit Test to verify that the user's email is not already taken by another user | Not Tested |  |  
 7 | 1.3, 1.3.1 | Unit Test to ensure the user supplies a password | Not Tested |  | 
 8 | 1.3.2 | Usability Test of the ability to hide password entries | Not Tested |  |
 9 | 1.3.3, 4.3.3 | Unit Test to ensure passwords meet strength criteria | Not Tested |  |
 10 | 1.3.3.1, 4.3.3 | Unit Test to verify passwords are at least 15 characters in length | Not Tested |  | 
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Prototype
The prototype for this web application is currently stored on the "dev" branch of my repository: [Prototype](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/dev/MSSA-CAD-Project-Lugias-Lair)

*Prototype Pictures:*
![Prototype Homepage](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Project%20Pictures/Prototype%20Pictures/Prototype%20-%20Homepage.jpg)

![Prototype Content Hub](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Project%20Pictures/Prototype%20Pictures/Prototype%20-%20Content%20Hub.jpg)

![Prototype Account Overview](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Project%20Pictures/Prototype%20Pictures/Prototype%20-%20Account%20Overview.jpg)

![Prototype Pokémon Search](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Project%20Pictures/Prototype%20Pictures/Prototype%20-%20Pokemon%20Search.jpg)

![Prototype Pokémon Customization](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Project%20Pictures/Prototype%20Pictures/Prototype%20-%20Pokemon%20Customization.jpg)

![Prototype Team Analysis](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Project%20Pictures/Prototype%20Pictures/Prototype%20-%20Team%20Analysis.jpg)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Entity Framework and Initial Model Scaffolding
To populate the data for my web application I am using Entity Framework (EF) Scaffolding, with a data-first approach. I first updated and added new SQL scripts to ensure the database tables had all of the appropriate fields, keys, and constraints necessary for the full scope of the web application. Although some tables do not have data in them as of 05 April 2020, the goal is to reduce the number of times I will need to perform the EF Scaffolding process throughout the remainder of the project. My updated SQL scripts are location in the folder [04. SQL Solution and Queries](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/04.%20SQLSolution%20and%20Queries), while the documents related to the actual EF Scaffolding and database diagram are stored here: [10. Database Diagram and EF Scaffolding](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/10.%20Database%20Diagram%20and%20EF%20Scaffolding).

After creating the necessary tables, my database diagram looks like this:
![Database Diagram (05APR2020)](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/10.%20Database%20Diagram%20and%20EF%20Scaffolding/SQL%20Database%20Table%20Diagram%20(05APR2020).jpg)

Unfortunately the diagram is hard to read in this format due to the large number of tables and relationships between them. The most important tables to note at this time are the main Pokémon table, the Custom Pokémon table, and the Team Base and Team VGC tables. These four tables will provide the bulk of the data necessary for the primary function of my web application. 

In order to perform EF Scaffolding, I first had to create a local DB within my web application solution in Visual Studio. I then ran the EF Scaffolding tool from the Packet Manager command line to generate the DB context and model classes. The final result of this initial EF Scaffolding can be seen in the picture below:
![Initial EF Scaffolding Results](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/10.%20Database%20Diagram%20and%20EF%20Scaffolding/Initial%20EF%20Migration%20(05APR2020).png)

The next steps will be to begin writing the controllers and views to allow users to interact with the models that EF created.
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)
## Connecting to the DB to Display/Modify Data
Although the Entity Framework scaffolding process automatically generates the model classes based on the database tables, there is still a lot more work to be done behind the scenes to link the model classes to the database and configure the database to connect to the web application. The general process is outlined in a how-to guide I made in the folder [10. Database Diagram and EF Scaffolding](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/10.%20Database%20Diagram%20and%20EF%20Scaffolding). 
The first step after the connection work has been completed is to test the ability of the application to display data stored in the database. Below are two screenshots demonstrating this basic functionality:
![Data Stored in the Pokémon Table](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2012%20Screenshots/Pokemon%20Data%20in%20localDB.jpg)
![Pokémon Data Displayed on Webpage](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2012%20Screenshots/Pokemon%20Data%20displayed%20on%20Webpage.jpg)

The next task is to demonstrate the ability to modify data in the database. I chose to start with the new user sign-up / account creation process. Below are two screenshots showing a fictional user signing up for an account and the user's data stored in the database at the end of the transaction (note: password encryption/hiding will be implemented, this is for demonstration purposes only).
![New User Sign-Up Form](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2012%20Screenshots/New%20User%20SIgn%20Up%20Form.jpg)
![Account Creation Successful Message](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2012%20Screenshots/New%20User%20SIgn%20Up%20Complete.jpg)
![New User Data Saved to Database](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2012%20Screenshots/New%20User%20Data%20Stored%20in%20localDB.jpg)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Initial Sprint Planning
As the end of the MSSA program comes nearer it has become imperative to deliberately plan all remaining tasks and prioritize them in order to ensure on-time completion. This will be done in the style of sprint planning on a one-week timescale. Each week I will select the most important issues from the overall [Issues](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/issues) list and add them to the current week's sprint. The progress of each sprint will be tracked on a Kanban board in the [Projects](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/projects) section. 

The first sprint occurred from 12 - 19 April 2020. At the start of that sprint, the overall Issue List looked like this:
![Initial Issue List](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2013%20Screenshots/Initial%20Issues%20List%20%2817APR2020%29.jpg)
Each Issue has, at minimum, a User Story that describes why the issue is important and an Acceptance Criteria that must be met before completing/closing the issue. Some issues had multiple sub-tasks, and each issue should also have a category label. An example issue is listed below:
![Example Issue](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2013%20Screenshots/Interface%20Issue%20Details%20%2817APR2020%29.jpg)
Each sprint project Kanban board will have three categories:

 - **To Do:** The overall list of tasks that must be complete at the end of the sprint
 - **Work In Progress:** Tasks currently being worked on (should be limited to 1-2 tasks at a time)
 - **Completed Work:** Tasks that have been completed

An example of how tasks flow through the sprint Kanban board is shown below:
![Kanban Board Progress](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2013%20Screenshots/Sprint%201%20Progress%20Overview%20%2818APR2020%29.jpg)
After a task is completed, it must be marked as closed on the Issue list. If all tasks for a given sprint are completed before the end of a sprint, then tasks may be added from the overall Issue list. Similarly, if a task cannot be completed during the current sprint, then it will be pushed onto the next week's sprint.
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Sprint Reviews
Continuing with weekly sprints, Sprint 2 occurred from 19 - 26 April. The starting Kanban board is pictured below:
![Starting Kanban Board](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2014%20Screenshots/Sprint%202%20-%20Kanban%20Board%20%2821APR2020%29.jpg)
Ideally I would have made progress each day and taken a screenshot of the updated Kanban board. However, I was not able to focus on the project until the end of the sprint, as the following screenshots will demonstrate:
![23APR2020 Kanban Board](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2014%20Screenshots/Sprint%202%20-%20Kanban%20Board%20%2823APR2020%29.jpg)
![24APR2020 Kanban Board](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2014%20Screenshots/Sprint%202%20-%20Kanban%20Board%20%2824APR2020%29.jpg)
![25APR2020 Kanban Board](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2014%20Screenshots/Sprint%202%20-%20Kanban%20Board%20%2825APR2020%29.jpg)

Another tool that I am using to plan and track my sprint progress is a burndown chart. This is a line graph that shows the starting number of tasks for a sprint, the ideal number of tasks completed each day, and the actual number of tasks completed each day. This makes it easier to look back and identify issues, whether the addition of new tasks mid-sprint or tasks taking longer than expected. The final burndown chart for Sprint 2 is below, and the most current burndown charts can be found in this folder: [11. Sprint Planning and Review](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/11.%20Sprint%20Planning%20and%20Review)

![Sprint 2 Burndown Chart](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/blob/master/ZZ.%20Pictures%20and%20Research/Step%2014%20Screenshots/Sprint%202%20BurndownChart%20%2825APR2020%29.jpg)
After completing a sprint, I will perform a sprint review and record the results in the same folder as the burndown charts. Each sprint review will cover the same four questions:

 - Did you complete all items in your sprint plan?
 - What is your sprint deliverable?
 - Did you have any task volatility, and what was the cause?
 - What would you do differently, knowing what you know now?

[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)
## End-Of-MSSA Test and Requirements Review
The MSSA program ends on 22 May 2020, therefore I am including my project's Test Status and Test Readiness Report as of 16 May 2020. However, I will continue to work on this project in my spare time even after completing the MSSA program. The full, itemized list of both requirements and tests can be found in the following folder: [09. Project Testing](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making/tree/master/09.%20Project%20Testing)

I started this project with a total of 117 requirements. As of 16 May 2020, I have implemented and have test coverage of 50 requirements, with a resulting requirements coverage of 42.74%. 

I wrote 102 tests to cover those 117 requirements. As of 16 May 2020, I have 47 passing tests, with the remaining not yet implemented/tested. That means I have a pass rate of 46.08% on my tests. 


[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)

## Project Work Backlog
A list of items that I may not be able to complete before the end of the MSSA program, but which I will continue working on once the core functionality of the web application is complete. 

 - [ ] Pokémon Moves Reverse-Lookup Tables
 - [ ] Pokémon Abilities Reverse-Lookup Tables
 - [ ] Add Pictures
 - [ ] Custom Stat Calculations (EVs, IVs, Base Stats)
 - [ ] Conditional Team Generator (Both Full Teams and VGC Teams)
 - [ ] In-Game Battle Information Dashboard
 - [ ] Battle Simulation Logic (this has been done by other sites
       already, and is essentially an entire project in and of itself)
[Return to Top](https://github.com/Bandit254/MSSA-Project-Pokemon-Decision-Making#mssa-project-pok%C3%A9mon-decision-making)
<!--stackedit_data:
eyJoaXN0b3J5IjpbOTE1NDcwODg2LC0xNDIzNjUzODgsNjk1OD
c2MjQ5LC0xNjQ0Mjg5NDk1LC05MzUyNTI4NzcsNzM0MzY5OTYz
LC0zMjU3Mjk3NTMsLTE3NDg5MDEyMTQsLTExMjA3MTkxMjIsLT
EzMTUxMzA2NzcsOTkwNDUzNTU2LDE4MzQyMzMyMDAsMzY5OTM0
NzUyLC0yNDU4MTc1MjEsLTExMzM1NzgzOSwtMjkxNTcwNDA0LC
0xNzgxMDg5Njg5LC0xMDA1NDAyOTM3LC0yMDM2ODYzMTkwLC0x
OTUwNzMzMzQ2XX0=
-->