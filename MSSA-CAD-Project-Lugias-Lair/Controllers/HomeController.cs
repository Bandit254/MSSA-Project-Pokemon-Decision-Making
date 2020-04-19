using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class HomeController : Controller 
    {
        private IPokemon repository;
        public HomeController(IPokemon repo)
        {
            repository = repo;
        }

        /*
         [HttpGet]
        public ViewResult SearchPokemon()
        {
            return View(repository.Pokemon);
        }
        */
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AccountOverview()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AnalyzeTeam()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ConditionalTeam()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ContentHub()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CreateTeam()
        {
            return View();
        }
        public ViewResult CustomizePokemon()
        {
            return View();
        }
        [HttpGet]
        public ViewResult InGameTracker()
        {
            return View();
        }
        [HttpGet]
        public ViewResult NewUserSignUp()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SearchTeams()
        {
            return View();
        }
        [HttpGet]
        public ViewResult UpdateAccount()
        {
            return View();
        }
        [HttpGet]
        public ViewResult VGCAnalysis()
        {
            return View();
        }
        [HttpGet]
        public ViewResult VGCTeamPicker()
        {
            return View();
        }
    }
}
