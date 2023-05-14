using Lab2_IT_211189.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2_IT_211189.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        private static List<EventModel> events = new List<EventModel>()
        {
            new EventModel
            {
                Name = "Back to the 90's!",
                Location = "Stanica26"
            }
        };

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowAllEvents()
        {
            return View(events);
        }
        public ActionResult NewEvent()
        {
            EventModel model = new EventModel();
            return View(model);
        }
        public ActionResult InsertNewEvent(EventModel model)
        {
            if(ModelState.IsValid == false)
            {
                return View("NewEvent");
            }
            events.Add(model);
            return View("DisplayInfo", model);
        }
        public ActionResult EditEvent(int id) {
        var model = events.ElementAt(id);
        model.Id = id;
        return View(model);
        }
        [HttpPost]
        public ActionResult EditEvent(EventModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewEvent");
            }
            var newevent = events.ElementAt(model.Id);
            newevent.Id = model.Id;
            newevent.Name = model.Name;
            newevent.Location = model.Location;
            return View("ShowAllEvents", events);
        }
        public ActionResult DeleteEvent(int id)
        {
            if (id >= 0)
            {
                events.RemoveAt(id);
                return View("ShowAllEvents", events);
            }
            return View("ShowAllEvents", events);
        }
    }
}