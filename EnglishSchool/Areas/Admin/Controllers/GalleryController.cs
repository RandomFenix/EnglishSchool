using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    [Area("Admin")]
    public class GalleryController : Controller
    {
        private readonly DataManager dataManager;
        public GalleryController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            var model = dataManager.Images.GetImages();
            return View(model);
        }
        public IActionResult GalleryEdit(Guid Id)
        {
            Gallery model = Id == default ? new Gallery() : dataManager.Images.GetImagesById(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult GalleryEdit(Gallery model)
        {
            if(ModelState.IsValid)
            {
                dataManager.Images.SaveImage(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteImage(Guid id)
        {
            dataManager.Images.DeleteImage(new Gallery { Id = id });
            return RedirectToAction("Index");
        }
    }
}
