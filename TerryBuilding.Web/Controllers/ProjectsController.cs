using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TerryBuilding.Web.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Commercial()
        {
            return View();
        }

        public ActionResult Industrial()
        {
            return View();
        }

        public ActionResult Agriculture()
        {
            return View();
        }

        public ActionResult Retail()
        {
            return View();
        }

        public ActionResult Religious()
        {
            return View();
        }
    }
}