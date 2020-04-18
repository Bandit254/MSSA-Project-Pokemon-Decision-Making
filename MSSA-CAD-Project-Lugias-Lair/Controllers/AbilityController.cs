using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class AbilityController : Controller
    {
        private IAbility repository;
        public AbilityController(IAbility repo)
        {
            repository = repo;
        }
        public ViewResult DisplayAbilities()
        {
            return View(repository.Abilities);
        }
    }
}
