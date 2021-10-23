using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using EnglishSchool.Data.Repositories.EntityFramework;
using EnglishSchool.Models;
using EnglishSchool.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    public class HomeController : Controller
    {
        private EFRequestRepository efRequestRepository = new EFRequestRepository();
        private readonly DataManager dataManager;
        private readonly Course course;
        private readonly ApplicationDbContext applicationDbContext;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public HomeController(DataManager dataManager, ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.dataManager = dataManager;
            this.applicationDbContext = applicationDbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            ViewBag.userTitle = userManager.GetUserName(HttpContext.User);
            var model = new SharedModelsToView { Courses = dataManager.Courses.GetCourses() };
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
    }
}
