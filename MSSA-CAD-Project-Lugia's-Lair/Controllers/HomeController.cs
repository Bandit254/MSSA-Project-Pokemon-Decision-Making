using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using MSSA_CAD_Project_Lugia_s_Lair.Models;

namespace MSSA_CAD_Project_Lugia_s_Lair.Controllers
{
    public class HomeController : Controller 
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
