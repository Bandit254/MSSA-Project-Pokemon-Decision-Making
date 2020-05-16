﻿using System;

namespace TeamAnalysisLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the algorithm to analyze a Pokemon team's strengths and weaknesses.\n");
            /*
            Console.WriteLine("Enter the first type of the Pokemon you want to analyze:\n");
            string firstType = Console.ReadLine();
            PokemonType typeOne = GetType(firstType);
            Console.WriteLine("If the Pokemon you want to analyze has a second type, enter it here. If your Pokemon only has one type, hit enter to continue:\n");
            string secondType = Console.ReadLine();
            PokemonType typeTwo = GetType(secondType);
            double[] attackRating = PokemonAttackRating(typeOne, typeTwo);
            double[] defenseRating = PokemonDefenseRating(typeOne, typeTwo);
            double[] overallRating = PokemonOverallRating(typeOne, typeTwo);
            Console.WriteLine($"\nThe attack rating for a Pokemon of type {firstType} and {secondType} is:\n");
            Console.WriteLine("Nor - Fir - Wat - Gra - Ele - Ice - Fig - Poi - Grn - Fly - Psy - Bug - Roc - Gho - Dra - Dar - Ste - Fai");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            foreach (double item in attackRating)
            {
                Console.Write($"{item} - ");
            }
            Console.WriteLine($"\nThe defense rating for a Pokemon of type {firstType} and {secondType} is:\n");
            Console.WriteLine("Nor - Fir - Wat - Gra - Ele - Ice - Fig - Poi - Grn - Fly - Psy - Bug - Roc - Gho - Dra - Dar - Ste - Fai");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            foreach (double item in defenseRating)
            {
                Console.Write($"{item} - ");
            }
            Console.WriteLine($"\nThe overall Strengths/Weaknesses for a Pokemon of type {firstType} and {secondType} is:\n");
            Console.WriteLine("Nor - Fir - Wat - Gra - Ele - Ice - Fig - Poi - Grn - Fly - Psy - Bug - Roc - Gho - Dra - Dar - Ste - Fai");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            foreach (double item in overallRating)
            {
                Console.Write($"{item} - ");
            }
            Console.WriteLine("\n");
            */
            TeamBase testBaseTeam = new TeamBase(PokemonType.Bug, PokemonType.Water, PokemonType.Electric, null, PokemonType.Fire, PokemonType.Flying, PokemonType.Grass, PokemonType.Poison, PokemonType.Dragon, null, PokemonType.Fairy, PokemonType.Psychic);
            testBaseTeam.DisplayTeamID();
            Console.WriteLine("\n");
            TeamVGC testVGCTeam = new TeamVGC(PokemonType.Flying, PokemonType.Psychic, PokemonType.Fire, null, PokemonType.Dark, PokemonType.Fighting, PokemonType.Rock, null);
            testVGCTeam.DisplayTeamID();
            Console.WriteLine("\n");
            double[] baseTeamRating = AnalyzeTeam(testBaseTeam);
            double[] vgcTeamRating = AnalyzeTeam(testVGCTeam);
            foreach (double x in baseTeamRating)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            foreach (double x in vgcTeamRating)
            {
                Console.Write($"{x} ");
            }
        }
        public enum PokemonType
        {
            Normal, Fire, Water, Grass, Electric, Ice, Fighting, Poison, Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy, TypeNull
        }
        public static PokemonType GetType(string pokemonType)
        {
            string typeUpper = pokemonType.ToUpper();
            PokemonType type;
            if (String.Equals(typeUpper, "NORMAL"))
            {
                type = PokemonType.Normal;
            }
            else if (String.Equals(typeUpper, "FIRE"))
            {
                type = PokemonType.Fire;
            }
            else if (String.Equals(typeUpper, "WATER"))
            {
                type = PokemonType.Water;
            }
            else if (String.Equals(typeUpper, "GRASS"))
            {
                type = PokemonType.Grass;
            }
            else if (String.Equals(typeUpper, "ELECTRIC"))
            {
                type = PokemonType.Electric;
            }
            else if (String.Equals(typeUpper, "ICE"))
            {
                type = PokemonType.Ice;
            }
            else if (String.Equals(typeUpper, "FIGHTING"))
            {
                type = PokemonType.Fighting;
            }
            else if (String.Equals(typeUpper, "POISON"))
            {
                type = PokemonType.Poison;
            }
            else if (String.Equals(typeUpper, "GROUND"))
            {
                type = PokemonType.Ground;
            }
            else if (String.Equals(typeUpper, "FLYING"))
            {
                type = PokemonType.Flying;
            }
            else if (String.Equals(typeUpper, "PSYCHIC"))
            {
                type = PokemonType.Psychic;
            }
            else if (String.Equals(typeUpper, "BUG"))
            {
                type = PokemonType.Bug;
            }
            else if (String.Equals(typeUpper, "ROCK"))
            {
                type = PokemonType.Rock;
            }
            else if (String.Equals(typeUpper, "GHOST"))
            {
                type = PokemonType.Ghost;
            }
            else if (String.Equals(typeUpper, "DRAGON"))
            {
                type = PokemonType.Dragon;
            }
            else if (String.Equals(typeUpper, "DARK"))
            {
                type = PokemonType.Dark;
            }
            else if (String.Equals(typeUpper, "STEEL"))
            {
                type = PokemonType.Steel;
            }
            else if (String.Equals(typeUpper, "FAIRY"))
            {
                type = PokemonType.Fairy;
            }
            else
            {
                type = PokemonType.TypeNull;
            }
            return type;
        }
        public static double[,] TypeChart = new double[18, 18] {
            //Normal
            { 1,1,1,1,1,1,1,1,1,1,1,1,0.5,0,1,1,0.5,1},
            //Fire
            {1,0.5,0.5,2,1,2,1,1,1,1,1,2,0.5,1,0.5,1,2,1 },
            //Water
            {1,2,0.5,0.5,1,1,1,1,2,1,1,1,2,1,0.5,1,1,1 },
            //Grass
            { 1,0.5,2,0.5,1,1,1,0.5,2,0.5,1,0.5,2,1,0.5,1,0.5,1},
            //Electric
            {1,1,2,0.5,0.5,1,1,1,0,2,1,1,1,1,0.5,1,1,1 },
            //Ice
            {1,0.5,0.5,2,1,0.5,1,1,2,2,1,1,1,1,2,1,0.5,1 },
            //Fighting
            { 2,1,1,1,1,2,1,0.5,1,0.5,0.5,0.5,1,0,1,2,2,0.5},
            //Poison
            {1,1,1,2,1,1,1,0.5,0.5,1,1,1,0.5,0.5,1,1,0,2 },
            //Ground
            { 1,2,1,0.5,2,1,1,2,1,0,1,0.5,2,1,1,1,2,1},
            //Flying
            { 1,1,1,2,0.5,1,2,1,1,1,1,2,0.5,1,1,1,0.5,1},
            //Psychic
            {1,1,1,1,1,1,2,2,1,1,0.5,1,1,1,1,0,0.5,1 },
            //Bug
            {1,0.5,1,2,1,1,0.5,0.5,1,0.5,2,1,1,0.5,1,2,0.5,0.5 },
            //Rock
            { 1,2,1,1,1,2,0.5,1,0.5,2,1,2,1,1,1,1,0.5,1},
            //Ghost
            {0,1,1,1,1,1,1,1,1,1,2,1,1,2,1,0.5,1,1 },
            //Dragon
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,0.5,0 },
            //Dark
            { 1,1,1,1,1,1,0.5,1,1,1,2,1,1,2,1,0.5,1,0.5},
            //Steel
            { 1,0.5,0.5,1,0.5,2,1,1,1,1,1,1,2,1,1,1,0.5,2},
            //Fairy
            {1,0.5,1,1,1,1,2,0.5,1,1,1,1,1,1,2,2,0.5,1 }
        };
        public static double[] PokemonAttackRating(PokemonType typeOne, PokemonType? typeTwo)
        {
            int typeOneIndex = (int)typeOne;
            double[] attackRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                attackRating[i] = TypeChart[typeOneIndex, i];
            }
            if (typeTwo!=null)
            {
                int typeTwoIndex = (int)typeTwo;
                for (int i = 0; i < 18; i++)
                {
                    attackRating[i] *= TypeChart[typeTwoIndex, i];
                }
            }
            return attackRating;
        }
        public static double[] PokemonDefenseRating(PokemonType typeOne, PokemonType? typeTwo)
        {
            int typeOneIndex = (int)typeOne;
            double[] defenseRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                defenseRating[i] = TypeChart[i, typeOneIndex];
            }
            if (typeTwo != null)
            {
                int typeTwoIndex = (int)typeTwo;
                for (int i = 0; i < 18; i++)
                {
                    defenseRating[i] *= TypeChart[i, typeTwoIndex];
                }
            }
            return defenseRating;
        }
        public static double[] PokemonOverallRating(PokemonType typeOne, PokemonType? typeTwo)
        {
            double[] overallRating = new double[18];
            double[] attackRating = PokemonAttackRating(typeOne, typeTwo);
            double[] defenseRating = PokemonDefenseRating(typeOne, typeTwo);
            for (int i = 0; i < 18; i++)
            {
                overallRating[i] = attackRating[i] - defenseRating[i];
            }
            return overallRating;
        }
        public struct TeamBase
        {
            private int teamID;
            public PokemonType pkmOneTypeOne;
            public PokemonType? pkmOneTypeTwo;

            public PokemonType pkmTwoTypeOne;
            public PokemonType? pkmTwoTypeTwo;

            public PokemonType pkmThreeTypeOne;
            public PokemonType? pkmThreeTypeTwo;

            public PokemonType pkmFourTypeOne;
            public PokemonType? pkmFourTypeTwo;

            public PokemonType pkmFiveTypeOne;
            public PokemonType? pkmFiveTypeTwo;

            public PokemonType pkmSixTypeOne;
            public PokemonType? pkmSixTypeTwo;
            public void DisplayTeamID()
            {
                Console.WriteLine($"This team's ID number is: {teamID}");
            }
            public TeamBase(PokemonType pkmOneTypeOne, PokemonType? pkmOneTypeTwo, PokemonType pkmTwoTypeOne, PokemonType? pkmTwoTypeTwo, PokemonType pkmThreeTypeOne, PokemonType pkmThreeTypeTwo, PokemonType pkmFourTypeOne, PokemonType? pkmFourTypeTwo, PokemonType pkmFiveTypeOne, PokemonType? pkmFiveTypeTwo, PokemonType pkmSixTypeOne, PokemonType? pkmSixTypeTwo)
            {
                Random tR = new Random();
                teamID = tR.Next(1000, 10001);
                this.pkmOneTypeOne = pkmOneTypeOne;
                this.pkmOneTypeTwo = pkmOneTypeTwo;
                this.pkmTwoTypeOne = pkmTwoTypeOne;
                this.pkmTwoTypeTwo = pkmTwoTypeTwo;
                this.pkmThreeTypeOne = pkmThreeTypeOne;
                this.pkmThreeTypeTwo = pkmThreeTypeTwo;
                this.pkmFourTypeOne = pkmFourTypeOne;
                this.pkmFourTypeTwo = pkmFourTypeTwo;
                this.pkmFiveTypeOne = pkmFiveTypeOne;
                this.pkmFiveTypeTwo = pkmFiveTypeTwo;
                this.pkmSixTypeOne = pkmSixTypeOne;
                this.pkmSixTypeTwo = pkmSixTypeTwo;
            }
        }
        public struct TeamVGC
        {
            private int teamID;
            public PokemonType pkmOneTypeOne;
            public PokemonType? pkmOneTypeTwo;

            public PokemonType pkmTwoTypeOne;
            public PokemonType? pkmTwoTypeTwo;

            public PokemonType pkmThreeTypeOne;
            public PokemonType? pkmThreeTypeTwo;

            public PokemonType pkmFourTypeOne;
            public PokemonType? pkmFourTypeTwo;
            public void DisplayTeamID()
            {
                Console.WriteLine($"This team's ID number is: {teamID}");
            }

            public TeamVGC(PokemonType pkmOneTypeOne, PokemonType? pkmOneTypeTwo, PokemonType pkmTwoTypeOne, PokemonType? pkmTwoTypeTwo, PokemonType pkmThreeTypeOne, PokemonType pkmThreeTypeTwo, PokemonType pkmFourTypeOne, PokemonType? pkmFourTypeTwo)
            {
                Random tR = new Random();
                teamID = tR.Next(1000, 10001);
                this.pkmOneTypeOne = pkmOneTypeOne;
                this.pkmOneTypeTwo = pkmOneTypeTwo;
                this.pkmTwoTypeOne = pkmTwoTypeOne;
                this.pkmTwoTypeTwo = pkmTwoTypeTwo;
                this.pkmThreeTypeOne = pkmThreeTypeOne;
                this.pkmThreeTypeTwo = pkmThreeTypeTwo;
                this.pkmFourTypeOne = pkmFourTypeOne;
                this.pkmFourTypeTwo = pkmFourTypeTwo;
            }
        }

        public static double[] AnalyzeTeam(TeamBase teamBase)
        {
            double[] pkmnOneRating = PokemonOverallRating(teamBase.pkmOneTypeOne, teamBase.pkmOneTypeTwo);
            double[] pkmnTwoRating = PokemonOverallRating(teamBase.pkmTwoTypeOne, teamBase.pkmTwoTypeTwo);
            double[] pkmnThreeRating = PokemonOverallRating(teamBase.pkmThreeTypeOne, teamBase.pkmThreeTypeTwo);
            double[] pkmnFourRating = PokemonOverallRating(teamBase.pkmFourTypeOne, teamBase.pkmFourTypeTwo);
            double[] pkmnFiveRating = PokemonOverallRating(teamBase.pkmFiveTypeOne, teamBase.pkmFiveTypeTwo);
            double[] pkmnSixRating = PokemonOverallRating(teamBase.pkmSixTypeOne, teamBase.pkmSixTypeTwo);
            double[] teamBaseRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                teamBaseRating[i] = pkmnOneRating[i] + pkmnTwoRating[i] + pkmnThreeRating[i] + pkmnFourRating[i] + pkmnFiveRating[i] + pkmnSixRating[i];
            }
            return teamBaseRating;
        }
        public static double[] AnalyzeTeam(TeamVGC teamVGC)
        {
            double[] pkmnOneRating = PokemonOverallRating(teamVGC.pkmOneTypeOne, teamVGC.pkmOneTypeTwo);
            double[] pkmnTwoRating = PokemonOverallRating(teamVGC.pkmTwoTypeOne, teamVGC.pkmTwoTypeTwo);
            double[] pkmnThreeRating = PokemonOverallRating(teamVGC.pkmThreeTypeOne, teamVGC.pkmThreeTypeTwo);
            double[] pkmnFourRating = PokemonOverallRating(teamVGC.pkmFourTypeOne, teamVGC.pkmFourTypeTwo);
            double[] teamVGCRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                teamVGCRating[i] = pkmnOneRating[i] + pkmnTwoRating[i] + pkmnThreeRating[i] + pkmnFourRating[i];
            }
            return teamVGCRating;
        }
    }
}