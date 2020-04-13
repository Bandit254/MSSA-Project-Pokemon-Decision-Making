using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class VgcplayerController : Controller
    {
        private IVgcplayer repository;
        public VgcplayerController(IVgcplayer repo)
        {
            repository = repo;
        }
        public ViewResult NewUserSignUp()
        {
            return View(new Vgcplayer());
        }
        
        [HttpPost]
        public IActionResult NewUserSignUp(Vgcplayer vgcplayer)
        {
            repository.SaveVgcplayer(vgcplayer);
            return RedirectToAction(nameof(SignupComplete));
        }
        public ViewResult SignupComplete()
        {
            return View();
        }


    }
}
