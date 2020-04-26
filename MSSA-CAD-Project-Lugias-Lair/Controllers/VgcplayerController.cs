using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;//
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class VgcplayerController : Controller
    {
        private IVgcplayer repository;
        const string UserID = "User ID";
        const string UserName = "User Name";
        public VgcplayerController(IVgcplayer repo)
        {
            repository = repo;
        }
        public ViewResult SignIn()//
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(Vgcplayer vgcplayer)//
        {
            Vgcplayer authUser = repository.Vgcplayers.Where(authUser => authUser.UserEmail == vgcplayer.UserEmail && authUser.UserPassword == vgcplayer.UserPassword).FirstOrDefault();
            if (authUser == null)
            {
                return View("SignIn");
            }
            else
            {
                HttpContext.Session.SetInt32(UserID, authUser.UserId);
                HttpContext.Session.SetString(UserName, authUser.UserName);
                return RedirectToAction("ContentHub","Home");
            }
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
        public ActionResult LogOut()
        {
            HttpContext.Session.Remove("User ID");
            HttpContext.Session.Remove("User Name");
            return RedirectToAction(nameof(SignIn));
        }
        public ViewResult AccountOverview()
        {
            return View();
        }
        public ViewResult UpdateAccount()
        {
            return View();
        }


    }
}
