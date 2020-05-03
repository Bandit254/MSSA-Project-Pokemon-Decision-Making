using System;
using System.Collections;//
using System.Linq.Expressions;//
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;
using System.Data.Entity;//

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
        public ViewResult SearchPokemon(string searchName, int? searchType, int? searchType2)
        {
            var searchResults = repository.Pokemon.Select(p => p);
            //Name only
            if (!String.IsNullOrEmpty(searchName) && searchType==null && searchType2==null)
            {
                searchResults = repository.Pokemon.Where(p => p.PokemonName.Contains(searchName));
            }
            //Type one only
            if (String.IsNullOrEmpty(searchName) && searchType != null && searchType2 == null)
            {
                searchResults = repository.Pokemon.Where(p => p.PokemonTypeOne==searchType || p.PokemonTypeTwo==searchType);
            }
            //Name and type one
            if (!String.IsNullOrEmpty(searchName) && searchType != null && searchType2 == null)
            {
                searchResults = repository.Pokemon.Where(p => (p.PokemonTypeOne == searchType || p.PokemonTypeTwo == searchType) && p.PokemonName.Contains(searchName));
            }
            //Type two only
            if (String.IsNullOrEmpty(searchName) && searchType == null && searchType2 != null)
            {
                searchResults = repository.Pokemon.Where(p => p.PokemonTypeOne == searchType2 || p.PokemonTypeTwo == searchType2);
            }
            //Name and type two
            if (!String.IsNullOrEmpty(searchName) && searchType == null && searchType2 != null)
            {
                searchResults = repository.Pokemon.Where(p => (p.PokemonTypeOne == searchType2 || p.PokemonTypeTwo == searchType2) && p.PokemonName.Contains(searchName));
            }
            //Name, type one and type two
            if (!String.IsNullOrEmpty(searchName) && searchType != null && searchType2 != null)
            {
                searchResults = repository.Pokemon.Where(p => (p.PokemonTypeOne == searchType || p.PokemonTypeTwo == searchType) && (p.PokemonTypeOne == searchType2 || p.PokemonTypeTwo == searchType2) && p.PokemonName.Contains(searchName));
            }
            return View(searchResults.ToList());
        }
        public ViewResult CustomizePokemon()
        {
            return View();
        }
        [HttpGet]
        public ViewResult DisplayAllPokemon()
        {
            return View(repository.Pokemon);
        }
    }
}
