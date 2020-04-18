using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class CustomPokemonController : Controller
    {
        private ICustomPokemon customPokemonRepository;
        private IPokemonHasAbility possibleAbilityRepository;
        private IPokemonLearnsMove possibleMoveRepository;
        public CustomPokemonController(ICustomPokemon customPokemonRepo, IPokemonHasAbility possibleAbilityRepo, IPokemonLearnsMove possibleMoveRepo)
        {
            customPokemonRepository = customPokemonRepo;
            possibleAbilityRepository = possibleAbilityRepo;
            possibleMoveRepository = possibleMoveRepo;
        }
        public ViewResult DisplayCustomPokemon()
        {
            return View(customPokemonRepository.CustomPokemons);
        }
    }
}
