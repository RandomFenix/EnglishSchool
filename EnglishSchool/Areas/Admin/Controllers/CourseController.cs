using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using EnglishSchool.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CourseController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult CoursesEdit(Guid id)
        {
            Course model = id == default ? new Course() : dataManager.Courses.GetCourseById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult CoursesEdit(Course model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Courses.SaveCourse(model);
                return RedirectToAction("CoursesEdit", "Course", new { area = "Admin" });
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult CourseDelete(Guid id)
        {
            dataManager.Courses.DeleteCourse(new Course { Id = id });
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
