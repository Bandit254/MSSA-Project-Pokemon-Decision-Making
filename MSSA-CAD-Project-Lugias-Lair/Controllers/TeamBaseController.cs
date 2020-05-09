using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

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
        public RedirectToActionResult SaveTeamBase()
        {
            if (teamBase.PokemonOne == null || teamBase.PokemonTwo == null || teamBase.PokemonThree == null || teamBase.PokemonFour == null || teamBase.PokemonFive == null || teamBase.PokemonSix == null)
            {
                return RedirectToAction("TeamBaseSaveError");
            }
            TeamBase saveTeamBase = new TeamBase(teamBase.TeamBaseName, teamBase.PokemonOneId, teamBase.PokemonTwoId, teamBase.PokemonThreeId, teamBase.PokemonFourId, teamBase.PokemonFiveId, teamBase.PokemonSixId, teamBase.UserId, (int)teamBase.TeamPublic);
            repository.SaveTeamBase(saveTeamBase);
            teamBase.ClearPokemonTB();
            return RedirectToAction("TeamBaseSaveSuccessful");
        }

        public ViewResult TeamBaseFullError() => View();
        public ViewResult TeamBaseSaveError() => View();
        public ViewResult TeamBaseDuplicateError() => View();
        public ViewResult TeamBaseSaveSuccessful() => View();







        public ViewResult DisplayAllBaseTeams()
        {
            return View(repository.TeamBases);
        }
        [HttpGet]
        public ViewResult CreateTeam()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AnalyzeTeam()
        {
            return View();
        }
        [HttpGet]
        public ViewResult SearchTeams()
        {
            return View();
        }
    }
}
