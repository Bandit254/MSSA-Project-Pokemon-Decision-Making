using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;
using MSSA_CAD_Project_Lugias_Lair.Models.ViewModels;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class TeamBaseController : Controller
    {
        private ITeamBase repository;
        private TeamBase teamBase;
        private IPokemon pokemonRepository;
        public TeamBaseController(ITeamBase repo, TeamBase teamBaseService, IPokemon pokemonRepo)
        {
            repository = repo;
            teamBase = teamBaseService;
            pokemonRepository = pokemonRepo;
        }
        public ViewResult Index()
        {
            return View(teamBase);
        }
        public RedirectToActionResult AddToTeamBase(int pokemonId)
        {
            if (teamBase.PokemonOne != null && teamBase.PokemonTwo != null && teamBase.PokemonThree != null && teamBase.PokemonFour != null && teamBase.PokemonFive != null && teamBase.PokemonSix != null)
            {
                return RedirectToAction("TeamBaseFullError");
               
            }
            if (pokemonId==teamBase.PokemonOneId || pokemonId == teamBase.PokemonTwoId || pokemonId == teamBase.PokemonThreeId || pokemonId == teamBase.PokemonFourId || pokemonId == teamBase.PokemonFiveId || pokemonId == teamBase.PokemonSixId)
            {
                return RedirectToAction("TeamBaseDuplicateError");
            }
            Pokemon pokemon = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == pokemonId);
            if (pokemon!=null)
            {
                teamBase.AddPokemonTB(pokemon);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromTeamBase(int pokemonId)
        {
            Pokemon pokemon = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == pokemonId);
            if (pokemon!=null)
            {
                teamBase.RemovePokemonTB(pokemon);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult ClearTeamBase()
        {
            teamBase.ClearPokemonTB();
            return RedirectToAction("Index");
        }
        public RedirectToActionResult SetTeamBaseName(string teamBaseName)
        {
            teamBase.SetTeamBaseName(teamBaseName);
            return RedirectToAction("Index");
        }
        public RedirectToActionResult MarkTeamBasePublic(int teamPublic)
        {
            teamBase.MarkTeamBasePublic(teamPublic);
            return RedirectToAction("Index");
        }
        public RedirectToActionResult SaveTeamBase()
        {
            if (teamBase.PokemonOne == null || teamBase.PokemonTwo == null || teamBase.PokemonThree == null || teamBase.PokemonFour == null || teamBase.PokemonFive == null || teamBase.PokemonSix == null)
            {
                return RedirectToAction("TeamBaseSaveError");
            }
            TeamBase saveTeamBase = new TeamBase(teamBase.TeamBaseName, teamBase.PokemonOneId, teamBase.PokemonTwoId, teamBase.PokemonThreeId, teamBase.PokemonFourId, teamBase.PokemonFiveId, teamBase.PokemonSixId, teamBase.UserId, teamBase.TeamPublic);
            repository.SaveTeamBase(saveTeamBase);
            teamBase.ClearPokemonTB();
            return RedirectToAction("TeamBaseSaveSuccessful");
        }

        public ViewResult TeamBaseFullError() => View();
        public ViewResult TeamBaseSaveError() => View();
        public ViewResult TeamBaseDuplicateError() => View();
        public ViewResult TeamBaseSaveSuccessful() => View();
        private TeamBase ReassembleTeam(TeamBase teamBase)
        {
            teamBase.PokemonOne = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonOneId);
            teamBase.PokemonTwo = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonTwoId);
            teamBase.PokemonThree = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonThreeId);
            teamBase.PokemonFour = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonFourId);
            teamBase.PokemonFive = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonFiveId);
            teamBase.PokemonSix = pokemonRepository.Pokemon.FirstOrDefault(p => p.PokemonId == teamBase.PokemonSixId);
            return teamBase;
        }
        public ViewResult DisplayAllBaseTeams()
        {
            var allPublicTeams = repository.TeamBases.Where(t => t.TeamPublic == 1);
            List<TeamBase> publicBaseTeams = allPublicTeams.ToList();
            for (int i = 0; i < publicBaseTeams.Count; i++)
            {
                publicBaseTeams[i] = ReassembleTeam(publicBaseTeams[i]);
            }
            return View(publicBaseTeams);
        }
        [HttpGet]
        public ViewResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AnalyzeTeam(int teamBaseId)
        {
            teamBase = ReassembleTeam(repository.TeamBases.FirstOrDefault(t => t.TeamBaseId == teamBaseId));
            TeamBaseAnalysisViewModel teamBaseAnalysisViewModel = new TeamBaseAnalysisViewModel
            {
                TeamBase = teamBase,
                TeamStatAverages = StatAnalysis(teamBase),
                TeamTypeAnalysis = TypeAnalysis(teamBase),
            };
            return View(teamBaseAnalysisViewModel);
        }
        private int[] StatAnalysis(TeamBase teamBase)
        {
            int[] teamStatAverages = new int[7];
            int avgBaseTotal = ((int)(teamBase.PokemonOne.PokemonStatTotal + teamBase.PokemonTwo.PokemonStatTotal + teamBase.PokemonThree.PokemonStatTotal + teamBase.PokemonFour.PokemonStatTotal + teamBase.PokemonFive.PokemonStatTotal + teamBase.PokemonSix.PokemonStatTotal)) / 6;
            int avgHitPoints = ((int)(teamBase.PokemonOne.PokemonHitPoints + teamBase.PokemonTwo.PokemonHitPoints + teamBase.PokemonThree.PokemonHitPoints + teamBase.PokemonFour.PokemonHitPoints + teamBase.PokemonFive.PokemonHitPoints + teamBase.PokemonSix.PokemonHitPoints)) / 6;
            int avgAttack = ((int)(teamBase.PokemonOne.PokemonAttack + teamBase.PokemonTwo.PokemonAttack + teamBase.PokemonThree.PokemonAttack + teamBase.PokemonFour.PokemonAttack + teamBase.PokemonFive.PokemonAttack + teamBase.PokemonSix.PokemonAttack)) / 6;
            int avgDefense = ((int)(teamBase.PokemonOne.PokemonDefense + teamBase.PokemonTwo.PokemonDefense + teamBase.PokemonThree.PokemonDefense + teamBase.PokemonFour.PokemonDefense + teamBase.PokemonFive.PokemonDefense + teamBase.PokemonSix.PokemonDefense)) / 6;
            int avgSpAttack = ((int)(teamBase.PokemonOne.PokemonSpecialAttack + teamBase.PokemonTwo.PokemonSpecialAttack + teamBase.PokemonThree.PokemonSpecialAttack + teamBase.PokemonFour.PokemonSpecialAttack + teamBase.PokemonFive.PokemonSpecialAttack + teamBase.PokemonSix.PokemonSpecialAttack)) / 6;
            int avgSpDefense = ((int)(teamBase.PokemonOne.PokemonSpecialDefense + teamBase.PokemonTwo.PokemonSpecialDefense + teamBase.PokemonThree.PokemonSpecialDefense + teamBase.PokemonFour.PokemonSpecialDefense + teamBase.PokemonFive.PokemonSpecialDefense + teamBase.PokemonSix.PokemonSpecialDefense)) / 6;
            int avgSpeed = ((int)(teamBase.PokemonOne.PokemonSpeed + teamBase.PokemonTwo.PokemonSpeed + teamBase.PokemonThree.PokemonSpeed + teamBase.PokemonFour.PokemonSpeed + teamBase.PokemonFive.PokemonSpeed + teamBase.PokemonSix.PokemonSpeed)) / 6;
            teamStatAverages[0] = avgBaseTotal;
            teamStatAverages[1] = avgHitPoints;
            teamStatAverages[2] = avgAttack;
            teamStatAverages[3] = avgDefense;
            teamStatAverages[4] = avgSpAttack;
            teamStatAverages[5] = avgSpDefense;
            teamStatAverages[6] = avgSpeed;
            return teamStatAverages;
        }
        private double[] TypeAnalysis(TeamBase teamBase)
        {
            double[] pokemonOneTA = PokemonOverallRating((int)teamBase.PokemonOne.PokemonTypeOne, teamBase.PokemonOne.PokemonTypeTwo);
            double[] pokemonTwoTA = PokemonOverallRating((int)teamBase.PokemonTwo.PokemonTypeOne, teamBase.PokemonTwo.PokemonTypeTwo);
            double[] pokemonThreeTA = PokemonOverallRating((int)teamBase.PokemonThree.PokemonTypeOne, teamBase.PokemonThree.PokemonTypeTwo);
            double[] pokemonFourTA = PokemonOverallRating((int)teamBase.PokemonFour.PokemonTypeOne, teamBase.PokemonFour.PokemonTypeTwo);
            double[] pokemonFiveTA = PokemonOverallRating((int)teamBase.PokemonFive.PokemonTypeOne, teamBase.PokemonFive.PokemonTypeTwo);
            double[] pokemonSixTA = PokemonOverallRating((int)teamBase.PokemonSix.PokemonTypeOne, teamBase.PokemonSix.PokemonTypeTwo);
            double[] teamTypeAnalysis = new double[18];
            for (int i = 0; i < 18; i++)
            {
                teamTypeAnalysis[i] = pokemonOneTA[i] + pokemonTwoTA[i] + pokemonThreeTA[i] + pokemonFourTA[i] + pokemonFiveTA[i] + pokemonSixTA[i];
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
            int typeOneIndex = typeOne-1;
            double[] attackRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                attackRating[i] = TypeChart[typeOneIndex, i];
            }
            if (typeTwo != null)
            {
                int typeTwoIndex = (int)typeTwo-1;
                for (int i = 0; i < 18; i++)
                {
                    attackRating[i] *= TypeChart[typeTwoIndex, i];
                }
            }
            return attackRating;
        }
        private double[] PokemonDefenseRating(int typeOne, int? typeTwo)
        {
            int typeOneIndex = typeOne-1;
            double[] defenseRating = new double[18];
            for (int i = 0; i < 18; i++)
            {
                defenseRating[i] = TypeChart[i, typeOneIndex];
            }
            if (typeTwo != null)
            {
                int typeTwoIndex = (int)typeTwo-1;
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


        [HttpGet]
        public ViewResult SearchTeams()
        {
            return View();
        }
    }
}
