﻿using System;
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
        public ViewResult DisplayAllNatures()
        {
            return View(repository.Natures);
        }
    }
}
