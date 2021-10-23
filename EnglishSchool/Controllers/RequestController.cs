using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using EnglishSchool.Data.Repositories.EntityFramework;
using EnglishSchool.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    public class RequestController : Controller
    {
        private EFRequestRepository efRequestRepository = new EFRequestRepository();
        private readonly DataManager dataManager;
        private readonly Course course;
        private readonly ApplicationDbContext applicationDbContext;
        public RequestController (DataManager dataManager, ApplicationDbContext applicationDbContext)
        {
            this.dataManager = dataManager;
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var model = new SharedModelsToView { Courses = dataManager.Courses.GetCourses()};
            var title = model.Courses.Select(t => t.Title).ToList();

            List<SelectListItem> courses = new List<SelectListItem>
            {
                new SelectListItem {Text = "", Value =""}
            };
            foreach (var item in title)
            {
                courses.Add(new SelectListItem { Text = $"{item}", Value = $"{item}" });
            }
            ViewBag.courses = courses;
            return View(model);
        }
        public IActionResult SendRequest(Request request, Config config)
        {
            efRequestRepository.SendEmail(request, config);
            return RedirectToAction("Confirm", "Home");
        }
    }
}
