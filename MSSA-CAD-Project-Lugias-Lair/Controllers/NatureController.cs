using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class NatureController : Controller
    {
        private INature repository;
        public NatureController(INature repo)
        {
            repository = repo;
        }
        [HttpGet]
        public ViewResult DisplayAllNatures(string searchName, string boostedStat, string decreasedStat, string dislikedBerry)
        {
            var searchResult = repository.Natures.Select(n => n);
            //Name only
            if (!String.IsNullOrEmpty(searchName) && String.IsNullOrEmpty(boostedStat) && String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureName.Contains(searchName));
            }
            //Name and boosted stat
            if (!String.IsNullOrEmpty(searchName) && !String.IsNullOrEmpty(boostedStat) && String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureName.Contains(searchName) && n.NatureIncreses.Contains(boostedStat));
            }
            //Name and decreased stat
            if (!String.IsNullOrEmpty(searchName) && String.IsNullOrEmpty(boostedStat) && !String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureName.Contains(searchName) && n.NatureDecreases.Contains(decreasedStat));
            }
            //Name, boosted stat and decreased stat
            if (!String.IsNullOrEmpty(searchName) && !String.IsNullOrEmpty(boostedStat) && !String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureName.Contains(searchName) && n.NatureIncreses.Contains(boostedStat) && n.NatureDecreases.Contains(decreasedStat));
            }
            //Name and disliked berry
            if (!String.IsNullOrEmpty(searchName) && String.IsNullOrEmpty(boostedStat) && String.IsNullOrEmpty(decreasedStat) && !String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureName.Contains(searchName) && n.NatureBerryDislike.Contains(dislikedBerry));
            }
            //Name, boosted, decreases, disliked
            if (!String.IsNullOrEmpty(searchName) && !String.IsNullOrEmpty(boostedStat) && !String.IsNullOrEmpty(decreasedStat) && !String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureName.Contains(searchName) && n.NatureIncreses.Contains(boostedStat) && n.NatureDecreases.Contains(decreasedStat) && n.NatureBerryDislike.Contains(dislikedBerry));
            }
            //boosted stat only
            if (String.IsNullOrEmpty(searchName) && !String.IsNullOrEmpty(boostedStat) && String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureIncreses.Contains(boostedStat));
            }
            //decreased stat only
            if (String.IsNullOrEmpty(searchName) && String.IsNullOrEmpty(boostedStat) && !String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureDecreases.Contains(decreasedStat));
            }
            //berry only
            if (String.IsNullOrEmpty(searchName) && String.IsNullOrEmpty(boostedStat) && String.IsNullOrEmpty(decreasedStat) && !String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureBerryDislike.Contains(dislikedBerry));
            }
            //both stats only
            if (String.IsNullOrEmpty(searchName) && !String.IsNullOrEmpty(boostedStat) && !String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureIncreses.Contains(boostedStat) && n.NatureDecreases.Contains(decreasedStat));
            }
            //both stats and berry
            if (String.IsNullOrEmpty(searchName) && !String.IsNullOrEmpty(boostedStat) && !String.IsNullOrEmpty(decreasedStat) && String.IsNullOrEmpty(dislikedBerry))
            {
                searchResult = repository.Natures.Where(n => n.NatureIncreses.Contains(boostedStat) && n.NatureDecreases.Contains(decreasedStat) && n.NatureBerryDislike.Contains(dislikedBerry));
            }
            return View(searchResult.ToList());
        }
    }
}
