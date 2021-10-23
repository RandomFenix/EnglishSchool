using EnglishSchool.Data;
using EnglishSchool.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataManager dataManager;
        public CourseController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            var model = dataManager.Courses.GetCourses();
            return View(model);
        }
    }
}
