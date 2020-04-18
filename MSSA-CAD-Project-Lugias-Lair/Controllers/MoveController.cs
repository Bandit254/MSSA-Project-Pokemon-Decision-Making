using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class MoveController : Controller
    {
        private IPokemonMove repository;
        public MoveController(IPokemonMove repo)
        {
            repository = repo;
        }
        public ViewResult DisplayAllMoves()
        {
            return View(repository.PokemonMoves);
        }
    }
}
