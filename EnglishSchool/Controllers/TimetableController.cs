using EnglishSchool.Models.Calendar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    public class TimetableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrevMonth()
        {
            return View();
        }

        public IActionResult NextMonth()
        {
            return View();
        }
    }
}
