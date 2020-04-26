using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class TeamVgcController : Controller
    {
        private ITeamBase teamBaseRepository;
        private ITeamVgc teamVgcRepository;
        public TeamVgcController(ITeamBase teamBaseRepo, ITeamVgc teamVgcRepo)
        {
            teamBaseRepository = teamBaseRepo;
            teamVgcRepository = teamVgcRepo;
        }
        public ViewResult DisplayVgcTeams()
        {
            return View(teamVgcRepository.TeamVgcs);
        }
        [HttpGet]
        public ViewResult VGCAnalysis()
        {
            return View();
        }
        [HttpGet]
        public ViewResult VGCTeamPicker()
        {
            return View();
        }
    }
}
