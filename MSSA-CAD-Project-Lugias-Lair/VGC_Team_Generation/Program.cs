using System;
using System.Collections.Generic;

namespace VGC_Team_Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test of algorithm to generate all possible VGC Teams from a given Base Team.\n");
            Console.WriteLine("Each base team has 6 Pokemon, but a VGC team may contain only 4 Pokemon.\n");
            Console.WriteLine("Therefore, there should be 15 unique ways to select 4 Pokemon from a base team of 6.\n");
            string[] baseTeam = new string[] { "Charizard", "Blastoise", "Venusaur", "Snorlax", "Pikachu", "Lapras" };
            List<string[]> vgcCombinations = GenerateTeams(baseTeam);
            Console.WriteLine("\n");
            for (int i = 0; i < vgcCombinations.Count; i++)
            {
                Console.WriteLine($"VGC Team #{i + 1}:");
                foreach (string pokemon in vgcCombinations[i])
                {
                    Console.WriteLine($"{pokemon}");
                }
                Console.WriteLine("\n");
            }
        }

        public static List<string[]> GenerateTeams(string[] baseTeam)
        {
            List<string[]> vgcCombinations = new List<string[]>();
            int x = 0;
            for (int h = 0; h < baseTeam.Length-3; h++)
            {
                for (int i = h+1; i < baseTeam.Length - 2; i++)
                {
                    for (int j = i+1; j < baseTeam.Length - 1; j++)
                    {
                        for (int k = j+1; k < baseTeam.Length; k++)
                        {
                            vgcCombinations.Add(new string[] { baseTeam[h], baseTeam[i], baseTeam[j], baseTeam[k] });
                            Console.WriteLine($"VGC Team combo #{x+1} has been added to the list");
                            x++;
                        }
                    }
                }
            }
            return vgcCombinations;
        }
    }
}
