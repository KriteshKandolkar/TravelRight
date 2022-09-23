using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelRight2020.Controllers
{
    public class TravelRightController : Controller
    {
        // GET: TravelRight
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}