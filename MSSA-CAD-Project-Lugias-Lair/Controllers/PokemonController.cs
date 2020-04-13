using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class PokemonController : Controller
    {
        private IPokemon repository;
        public PokemonController(IPokemon repo)
        {
            repository = repo;
        }
        [HttpGet]
        public ViewResult SearchPokemon() => View(repository.Pokemon);
        /*
        [HttpGet]
        public ViewResult SearchPokemon()
        {
            return View(repository.Pokemon);
        }
        */
    }
}
