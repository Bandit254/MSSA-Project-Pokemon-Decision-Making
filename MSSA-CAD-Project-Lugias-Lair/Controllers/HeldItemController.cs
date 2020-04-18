using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class HeldItemController : Controller
    {
        private IHeldItem repository;
        public HeldItemController(IHeldItem repo)
        {
            repository = repo;
        }
        public ViewResult DisplayAllItems()
        {
            return View(repository.HeldItems);
        }
    }
}
