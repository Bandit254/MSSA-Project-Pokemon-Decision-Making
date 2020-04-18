using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class TypeController : Controller
    {
        private IPokemonType repository;
        public TypeController(IPokemonType repo)
        {
            repository = repo;
        }
        public ViewResult DisplayAllTypes()
        {
            return View(repository.PokemonTypes);
        }
    }
}
