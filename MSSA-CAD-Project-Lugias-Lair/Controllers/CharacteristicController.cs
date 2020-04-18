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
        public ViewResult DisplayCharacteristics()
        {
            return View(repository.Characteristics);
        }
    }
}
