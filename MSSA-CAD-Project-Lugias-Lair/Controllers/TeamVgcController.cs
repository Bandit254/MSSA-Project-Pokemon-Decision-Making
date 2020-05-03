using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;
using MSSA_CAD_Project_Lugias_Lair.Models.ViewModels;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class TeamVgcController : Controller
    {
        private ITeamBase teamBaseRepository;
        private ITeamVgc teamVgcRepository;
        public TeamVgcController(ITeamBase teamBaseRepo, ITeamVgc teamVgcRepo)
        {
            teamBaseRepository = teamBaseRepo;
            teamVgcRepository = teamVgcRepo;
        }

        [HttpGet]
        public ViewResult VGCAnalysis()
        {
            string[] baseTeam = new string[] { "Charizard", "Blastoise", "Venusaur", "Snorlax", "Pikachu", "Lapras" };
            List<string[]> vgcCombinations = new List<string[]>();
            int x = 0;
            for (int h = 0; h < baseTeam.Length - 3; h++)
            {
                for (int i = h + 1; i < baseTeam.Length - 2; i++)
                {
                    for (int j = i + 1; j < baseTeam.Length - 1; j++)
                    {
                        for (int k = j + 1; k < baseTeam.Length; k++)
                        {
                            vgcCombinations.Add(new string[] { baseTeam[h], baseTeam[i], baseTeam[j], baseTeam[k] });
                        }
                    }
                }
            }
            return View(vgcCombinations);
        }
        [HttpPost]
        public ViewResult VGCAnalysis(string pokemonOne, string pokemonTwo, string pokemonThree, string pokemonFour, string pokemonFive, string pokemonSix)
        {
            string[] baseTeam = new string[] { pokemonOne, pokemonTwo, pokemonThree, pokemonFour, pokemonFive, pokemonSix };
            List<string[]> vgcCombinations = new List<string[]>();
            int x = 0;
            for (int h = 0; h < baseTeam.Length - 3; h++)
            {
                for (int i = h + 1; i < baseTeam.Length - 2; i++)
                {
                    for (int j = i + 1; j < baseTeam.Length - 1; j++)
                    {
                        for (int k = j + 1; k < baseTeam.Length; k++)
                        {
                            vgcCombinations.Add(new string[] { baseTeam[h], baseTeam[i], baseTeam[j], baseTeam[k] });
                        }
                    }
                }
            }
            return View(vgcCombinations);
        }
        [HttpGet]
        public ViewResult VGCTeamPicker()
        {
            return View();
        }
        public ViewResult DisplayVgcTeams()
        {
            return View(teamVgcRepository.TeamVgcs);
        }
    }
}
