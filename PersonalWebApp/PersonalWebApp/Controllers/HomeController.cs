using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Personal History:";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message1 = "Projects completed and currently in progress:";
            ViewBag.Message2 = "Technical Skills:";

            return View();
        }
    }
}