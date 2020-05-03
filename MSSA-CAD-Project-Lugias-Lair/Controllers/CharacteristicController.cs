using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class CharacteristicController : Controller
    {
        private ICharacteristic repository;
        public CharacteristicController(ICharacteristic repo)
        {
            repository = repo;
        }
        [HttpGet]
        public ViewResult DisplayCharacteristics(string searchDescription, string boostedStat)
        {
            var searchResults = repository.Characteristics.Select(c => c);
            if (!String.IsNullOrEmpty(searchDescription) && String.IsNullOrEmpty(boostedStat))
            {
                searchResults = repository.Characteristics.Where(c => c.CharacteristicDescription.Contains(searchDescription));
            }
            if (String.IsNullOrEmpty(searchDescription) && !String.IsNullOrEmpty(boostedStat))
            {
                searchResults = repository.Characteristics.Where(c => c.BenefittingStat.Contains(boostedStat));
            }
            if (!String.IsNullOrEmpty(searchDescription) && !String.IsNullOrEmpty(boostedStat))
            {
                searchResults = repository.Characteristics.Where(c => c.CharacteristicDescription.Contains(searchDescription) && c.BenefittingStat.Contains(boostedStat));
            }
            return View(searchResults.ToList());
        }
    }
}
