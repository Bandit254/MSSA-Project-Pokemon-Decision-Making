using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class PokedexController : Controller
    {
        private IPokedexEntry repository;
        public PokedexController(IPokedexEntry repo)
        {
            repository = repo;
        }
        public ViewResult DisplayAllPokedexEntries()
        {
            return View(repository.PokedexEntries);
        }
    }
}
