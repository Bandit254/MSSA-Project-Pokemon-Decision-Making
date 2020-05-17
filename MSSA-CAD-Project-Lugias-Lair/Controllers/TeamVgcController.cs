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
            List<int[]> vgcStatAverages = new List<int[]>();
            foreach (var vgcTeam in vgcCombinations)
            {
                vgcStatAverages.Add(StatAnalysisVGC(vgcTeam));
            }
            List<double[]> vgcTypeAnalysis = new List<double[]>();
            foreach (var vgcTeam in vgcCombinations)
            {
                vgcTypeAnalysis.Add(TypeAnalysisVGC(vgcTeam));
            }
            TeamVgsAnalysisViewModel teamVgsAnalysisViewModel = new TeamVgsAnalysisViewModel
            {
                TeamBase = teamBase,
                TeamVgcs = vgcCombinations,
                VgcStatAnalysis=vgcStatAverages,
                VgcTypeAnalysis = vgcTypeAnalysis,
            };
            return View(teamVgsAnalysisViewModel);
        }

        public RedirectToActionResult SaveTeamVGC(TeamVgc vgcTeam)
        {
            teamVgcRepository.SaveTeamVgc(vgcTeam);
            return RedirectToAction("VGCTeamSaved");
        }
        public ViewResult VGCTeamSaved() => View();

        [HttpGet]
        public ViewResult VGCTeamPicker()
        {
            return View();
        }
        public ViewResult DisplayVgcTeams()
        {
            List<TeamVgc> allSavedVGCTeams = teamVgcRepository.TeamVgcs.Select(v=>v).ToList();
            for (int i = 0; i < allSavedVGCTeams.Count; i++)
            {
                allSavedVGCTeams[i] = ReassembleTeamVGC(allSavedVGCTeams[i]);
            }
            return View(allSavedVGCTeams);
        }
        public TeamVgc ReassembleTeamVGC(TeamVgc vgcTeam)
        {
            vgcTeam.PkmnVgcone = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == vgcTeam.PkmnVgconeId);
            vgcTeam.PkmnVgctwo = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == vgcTeam.PkmnVgctwoId);
            vgcTeam.PkmnVgcthree = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == vgcTeam.PkmnVgcthreeId);
            vgcTeam.PkmnVgcfour = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == vgcTeam.PkmnVgcfourId);
            return vgcTeam;
        }
        private int[] StatAnalysisVGC(TeamVgc vgcTeam)
        {
            int[] teamStatAverages = new int[7];
            int avgBaseTotal = ((int)(vgcTeam.PkmnVgcone.PokemonStatTotal + vgcTeam.PkmnVgctwo.PokemonStatTotal + vgcTeam.PkmnVgcthree.PokemonStatTotal + vgcTeam.PkmnVgcfour.PokemonStatTotal)) / 4;
            int avgHitPoints = ((int)(vgcTeam.PkmnVgcone.PokemonHitPoints + vgcTeam.PkmnVgctwo.PokemonHitPoints + vgcTeam.PkmnVgcthree.PokemonHitPoints + vgcTeam.PkmnVgcfour.PokemonHitPoints)) / 4;
            int avgAttack = ((int)(vgcTeam.PkmnVgcone.PokemonAttack + vgcTeam.PkmnVgctwo.PokemonAttack + vgcTeam.PkmnVgcthree.PokemonAttack + vgcTeam.PkmnVgcfour.PokemonAttack)) / 4;
            int avgDefense = ((int)(vgcTeam.PkmnVgcone.PokemonDefense + vgcTeam.PkmnVgctwo.PokemonDefense + vgcTeam.PkmnVgcthree.PokemonDefense + vgcTeam.PkmnVgcfour.PokemonDefense)) / 4;
            int avgSpAttack = ((int)(vgcTeam.PkmnVgcone.PokemonSpecialAttack + vgcTeam.PkmnVgctwo.PokemonSpecialAttack + vgcTeam.PkmnVgcthree.PokemonSpecialAttack + vgcTeam.PkmnVgcfour.PokemonSpecialAttack)) / 4;
            int avgSpDefense = ((int)(vgcTeam.PkmnVgcone.PokemonSpecialDefense + vgcTeam.PkmnVgctwo.PokemonSpecialDefense + vgcTeam.PkmnVgcthree.PokemonSpecialDefense + vgcTeam.PkmnVgcfour.PokemonSpecialDefense)) / 4;
            int avgSpeed = ((int)(vgcTeam.PkmnVgcone.PokemonSpeed + vgcTeam.PkmnVgctwo.PokemonSpeed + vgcTeam.PkmnVgcthree.PokemonSpeed + vgcTeam.PkmnVgcfour.PokemonSpeed )) /4;
            teamStatAverages[0] = avgBaseTotal;
            teamStatAverages[1] = avgHitPoints;
            teamStatAverages[2] = avgAttack;
            teamStatAverages[3] = avgDefense;
            teamStatAverages[4] = avgSpAttack;
            teamStatAverages[5] = avgSpDefense;
            teamStatAverages[6] = avgSpeed;
            return teamStatAverages;
        }
        private double[] TypeAnalysisVGC(TeamVgc vgcTeam)
        {
            double[] pokemonOneTA = PokemonOverallRating((int)vgcTeam.PkmnVgcone.PokemonTypeOne, vgcTeam.PkmnVgcone.PokemonTypeTwo);
            double[] pokemonTwoTA = PokemonOverallRating((int)vgcTeam.PkmnVgctwo.PokemonTypeOne, vgcTeam.PkmnVgctwo.PokemonTypeTwo);
            double[] pokemonThreeTA = PokemonOverallRating((int)vgcTeam.PkmnVgcthree.PokemonTypeOne, vgcTeam.PkmnVgcthree.PokemonTypeTwo);
            double[] pokemonFourTA = PokemonOverallRating((int)vgcTeam.PkmnVgcfour.PokemonTypeOne, vgcTeam.PkmnVgcfour.PokemonTypeTwo);
            double[] teamTypeAnalysis = new double[18];
            for (int i = 0; i < 18; i++)
            {
                teamTypeAnalysis[i] = pokemonOneTA[i] + pokemonTwoTA[i] + pokemonThreeTA[i] + pokemonFourTA[i];
            }
            return teamTypeAnalysis;
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
        private double[] PokemonAttackRating(int typeOne, int? typeTwo)
        {
            int typeOneIndex = typeOne - 1;
            double[] attackRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                attackRating[i] = TypeChart[typeOneIndex, i];
            }
            if (typeTwo != null)
            {
                int typeTwoIndex = (int)typeTwo - 1;
                for (int i = 0; i < 18; i++)
                {
                    attackRating[i] *= TypeChart[typeTwoIndex, i];
                }
            }
            return attackRating;
        }
        private double[] PokemonDefenseRating(int typeOne, int? typeTwo)
        {
            int typeOneIndex = typeOne - 1;
            double[] defenseRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                defenseRating[i] = TypeChart[i, typeOneIndex];
            }
            if (typeTwo != null)
            {
                int typeTwoIndex = (int)typeTwo - 1;
                for (int i = 0; i < 18; i++)
                {
                    defenseRating[i] *= TypeChart[i, typeTwoIndex];
                }
            }
            return defenseRating;
        }
        private double[] PokemonOverallRating(int typeOne, int? typeTwo)
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



    }
}
