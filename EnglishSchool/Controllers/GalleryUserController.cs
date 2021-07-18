using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    public class GalleryUserController : Controller
    {
        private readonly DataManager dataManager;
        public GalleryUserController (DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            var model = dataManager.Images.GetImages();
            return View(model);
        }
        public IActionResult ImagesEdit(Guid id)
        {
            Gallery model = id == default ? new Gallery() : dataManager.Images.GetImagesById(id);
            return View(model);
        }
    }
}
