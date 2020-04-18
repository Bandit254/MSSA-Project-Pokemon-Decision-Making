using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Controllers
{
    public class PictureController : Controller
    {
        private IPictureFull fullPicRepository;
        private IPictureSprite spritePicRepository;
        private IPictureTrainerSprite trainerPicRepository;
        public PictureController(IPictureFull fullPicRepo, IPictureSprite spritePicRepo, IPictureTrainerSprite trainerPicRepo)
        {
            fullPicRepository = fullPicRepo;
            spritePicRepository = spritePicRepo;
            trainerPicRepository = trainerPicRepo;
        }
        public ViewResult DisplayPictureFulls()
        {
            return View(fullPicRepository.PictureFulls);
        }
        public ViewResult DisplayPictureSprites()
        {
            return View(spritePicRepository.PictureSprites);
        }
        public ViewResult DisplayTrainerSprites()
        {
            return View(trainerPicRepository.PictureTrainerSprites);
        }
    }
}
