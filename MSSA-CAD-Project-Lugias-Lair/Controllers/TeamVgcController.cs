using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;
using MSSA_CAD_Project_Lugias_Lair.Models.ViewModels;
using MSSA_CAD_Project_Lugias_Lair.Controllers;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class TeamVgcController : Controller
    {
        private ITeamBase teamBaseRepository;
        private ITeamVgc teamVgcRepository;
        private IPokemon pokemonRepository;
        public TeamVgcController(ITeamBase teamBaseRepo, ITeamVgc teamVgcRepo, IPokemon pokemonRepo)
        {
            teamBaseRepository = teamBaseRepo;
            teamVgcRepository = teamVgcRepo;
            pokemonRepository = pokemonRepo;
        }
        /*
        [HttpPost]
        public ViewResult VGCAnalysis(int teamBaseId)
        {
            TeamBase teamBase = teamBaseRepository.TeamBases.FirstOrDefault(t => t.TeamBaseId == teamBaseId);
            teamBase.PokemonOne = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonOneId);
            teamBase.PokemonTwo = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonTwoId);
            teamBase.PokemonThree = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonThreeId);
            teamBase.PokemonFour = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonFourId);
            teamBase.PokemonFive = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonFiveId);
            teamBase.PokemonSix = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonSixId);
            string[] baseTeamPokemonList = new string[] { 
                teamBase.PokemonOne.PokemonName,
                teamBase.PokemonTwo.PokemonName,
                teamBase.PokemonThree.PokemonName,
                teamBase.PokemonFour.PokemonName,
                teamBase.PokemonFive.PokemonName,
                teamBase.PokemonSix.PokemonName,
            };
            List<string[]> vgcCombinations = new List<string[]>();
            for (int h = 0; h < baseTeamPokemonList.Length - 3; h++)
            {
                for (int i = h + 1; i < baseTeamPokemonList.Length - 2; i++)
                {
                    for (int j = i + 1; j < baseTeamPokemonList.Length - 1; j++)
                    {
                        for (int k = j + 1; k < baseTeamPokemonList.Length; k++)
                        {
                            vgcCombinations.Add(new string[] { baseTeamPokemonList[h], baseTeamPokemonList[i], baseTeamPokemonList[j], baseTeamPokemonList[k] });
                        }
                    }
                }
            }
            return View(vgcCombinations);
        }
        */
        [HttpPost]
        public ViewResult VGCAnalysis(int teamBaseId)
        {
            TeamBase teamBase = teamBaseRepository.TeamBases.FirstOrDefault(t => t.TeamBaseId == teamBaseId);
            teamBase.PokemonOne = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonOneId);
            teamBase.PokemonTwo = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonTwoId);
            teamBase.PokemonThree = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonThreeId);
            teamBase.PokemonFour = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonFourId);
            teamBase.PokemonFive = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonFiveId);
            teamBase.PokemonSix = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonSixId);
            Pokemon[] teamBasePokemon = new Pokemon[] { teamBase.PokemonOne, teamBase.PokemonTwo, teamBase.PokemonThree, teamBase.PokemonFour, teamBase.PokemonFive, teamBase.PokemonSix };
            List<TeamVgc> vgcCombinations = new List<TeamVgc>();
            for (int h = 0; h < teamBasePokemon.Length - 3; h++)
            {
                for (int i = h + 1; i < teamBasePokemon.Length - 2; i++)
                {
                    for (int j = i + 1; j < teamBasePokemon.Length - 1; j++)
                    {
                        for (int k = j + 1; k < teamBasePokemon.Length; k++)
                        {
                            vgcCombinations.Add(new TeamVgc(teamBase.UserId, teamBase.TeamBaseId, teamBasePokemon[h], teamBasePokemon[i], teamBasePokemon[j], teamBasePokemon[k]));
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
