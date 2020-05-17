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
            Vgcplayer authUser = repository.Vgcplayers.Where(
                authUser => authUser.UserEmail == vgcplayer.UserEmail && authUser.UserPassword == vgcplayer.UserPassword).FirstOrDefault();
            if (authUser == null)
            {
                return View("SignIn");
            }
            else
            {
                HttpContext.Session.SetInt32(UserID, authUser.UserId);
                HttpContext.Session.SetString(UserName, authUser.UserName);
                return RedirectToAction("AccountOverview","VgcPlayer");
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
        public RedirectToActionResult DirectToAccountOverview()
        {
            if (HttpContext.Session.GetInt32("User ID")==null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AccountOverview");
        }
        [HttpGet]
        public ViewResult UpdateAccount()
        {
            Vgcplayer currentUser = repository.Vgcplayers.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("User ID"));
            if (currentUser==null)
            {
                return View("SignIn");
            }
            return View(currentUser);
        }
        [HttpPost]
        public IActionResult UpdateAccount(string newUserName, string currentPassword, string newPasswordV1, string newPasswordV2)
        {
            Vgcplayer currentUser = repository.Vgcplayers.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("User ID"));
            if (!String.Equals(currentUser.UserPassword, currentPassword))
            {
                return RedirectToAction("IncorrectPassword");
            }
            else if (newPasswordV1!=null && newPasswordV2 != null && !String.Equals(newPasswordV1, newPasswordV2))
            {
                return RedirectToAction("NewPasswordsDontMatch");
            }
            else
            {
                if (newPasswordV1 != null && newPasswordV2 != null && String.Equals(newPasswordV1, newPasswordV2))
                {
                    currentUser.UserPassword = newPasswordV2;
                }
                if (newUserName!=null)
                {
                    currentUser.UserName = newUserName;
                }
            }
            HttpContext.Session.SetString(UserName, currentUser.UserName);
            repository.SaveVgcplayer(currentUser);
            return RedirectToAction("AccountUpdateSuccessful");
        }
        public ViewResult IncorrectPassword() => View();
        public ViewResult NewPasswordsDontMatch() => View();
        public ViewResult AccountUpdateSuccessful() => View();
        [HttpGet]
        public ViewResult AccountOverview() => View();

    }
}
