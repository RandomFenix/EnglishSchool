using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using EnglishSchool.Models;
using Microsoft.AspNetCore.Mvc;
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
        private readonly DataManager dataManager;
        public HomeController (DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            var model = dataManager.Courses.GetCourses();
            return View(model);
        }
        public async Task<IActionResult> CoursesEdit(Guid id)
        {
            Course model = id == default ? new Course() : await dataManager.Courses.GetCourseByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult CoursesEdit(Course model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Courses.SaveCourse(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult CourseDelete(Guid id)
        {
            dataManager.Courses.DeleteCourse(new Course { Id = id });
            return RedirectToAction("Index");
        }

    }
}
