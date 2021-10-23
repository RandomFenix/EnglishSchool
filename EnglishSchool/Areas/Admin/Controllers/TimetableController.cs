using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using EnglishSchool.Data.Entities;
using System.Xml.Serialization;
using EnglishSchool.Data;

namespace EnglishSchool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TimetableController : Controller
    {
        private readonly DataManager dataManager;

        public TimetableController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            var model = dataManager.Events.GetDateEvents();
            return View(model);
        }
        public IActionResult TimetableEdit(Guid Id)
        {
            Timetable model = Id == default ? new Timetable() : dataManager.Events.GetEventsById(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult TimetableEdit(Timetable model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Events.SaveEvent(model);
                return View("Index");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteEvent(Guid id)
        {
            dataManager.Events.DeleteEvent(new Timetable { Id = id });
            return RedirectToAction("Index");
        }
    }
}
