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
        [HttpGet]
        public ViewResult DisplayAllItems(string searchType, string searchName)
        {
            var searchResults = repository.HeldItems.Select(i => i);
            if (!String.IsNullOrEmpty(searchType) && String.IsNullOrEmpty(searchName))
            {
                searchResults = repository.HeldItems.Where(i => i.ItemCat.Contains(searchType));
            }
            if (String.IsNullOrEmpty(searchType) && !String.IsNullOrEmpty(searchName))
            {
                searchResults = repository.HeldItems.Where(i => i.ItemName.Contains(searchName));
            }
            if (!String.IsNullOrEmpty(searchType) && !String.IsNullOrEmpty(searchName))
            {
                searchResults = repository.HeldItems.Where(i => i.ItemCat.Contains(searchType) && i.ItemName.Contains(searchName));
            }

            return View(searchResults.ToList());
        }
    }
}
