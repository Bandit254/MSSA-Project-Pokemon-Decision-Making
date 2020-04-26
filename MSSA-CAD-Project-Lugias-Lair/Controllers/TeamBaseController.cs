using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class TeamBaseController : Controller
    {
        private ITeamBase repository;
        public TeamBaseController(ITeamBase repo)
        {
            repository = repo;
        }
        public ViewResult DisplayAllBaseTeams()
        {
            return View(repository.TeamBases);
        }
        [HttpGet]
        public ViewResult CreateTeam()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AnalyzeTeam()
        {
            return View();
        }
        [HttpGet]
        public ViewResult SearchTeams()
        {
            return View();
        }
    }
}
