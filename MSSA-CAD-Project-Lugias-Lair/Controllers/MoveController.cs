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
        [HttpGet]
        public ViewResult DisplayAllMoves(string searchName, int? searchType, string searchCategory)
        {
            var searchResults = repository.PokemonMoves.Select(m => m);
            if (!String.IsNullOrEmpty(searchName) && searchType == null && String.IsNullOrEmpty(searchCategory))
            {
                searchResults = repository.PokemonMoves.Where(m => m.MoveName.Contains(searchName));
            }
            if (String.IsNullOrEmpty(searchName) && searchType != null && String.IsNullOrEmpty(searchCategory))
            {
                searchResults = repository.PokemonMoves.Where(m => m.MoveType==searchType);
            }
            if (String.IsNullOrEmpty(searchName) && searchType == null && !String.IsNullOrEmpty(searchCategory))
            {
                searchResults = repository.PokemonMoves.Where(m => m.MoveCategory.Contains(searchCategory));
            }
            if (!String.IsNullOrEmpty(searchName) && searchType != null && String.IsNullOrEmpty(searchCategory))
            {
                searchResults = repository.PokemonMoves.Where(m => m.MoveName.Contains(searchName) && m.MoveType == searchType);
            }
            if (!String.IsNullOrEmpty(searchName) && searchType == null && !String.IsNullOrEmpty(searchCategory))
            {
                searchResults = repository.PokemonMoves.Where(m => m.MoveName.Contains(searchName) && m.MoveCategory.Contains(searchCategory));
            }
            if (String.IsNullOrEmpty(searchName) && searchType != null && !String.IsNullOrEmpty(searchCategory))
            {
                searchResults = repository.PokemonMoves.Where(m => m.MoveType == searchType && m.MoveCategory.Contains(searchCategory));
            }
            return View(searchResults.ToList());
        }
    }
}
