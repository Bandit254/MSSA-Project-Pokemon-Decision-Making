using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Session;
using System.Web;
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
        public ViewResult Index()
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
        public ViewResult InGameTracker()
        {
            return View();
        }
        [HttpGet]
        public ViewResult NewUserSignUp()
        {
            return View();
        }




    }
}
