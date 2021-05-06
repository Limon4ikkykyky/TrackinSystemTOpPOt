using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackingSystem.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddTasks()
        {
            return View();
        }
        public ActionResult EditTasks()
        {
            return View();
        }
        public ActionResult DeleteTasks()
        {
            return View();
        }
    }
}