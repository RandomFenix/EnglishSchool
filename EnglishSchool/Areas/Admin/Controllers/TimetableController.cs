﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Controllers
{
    [Area("Admin")]
    public class TimetableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
