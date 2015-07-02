using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application was a quick attempt at the comp3026 midterm.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "<a href=\"michealpwalls@gmail.com\">michealpwalls@gmail.com</a>.";

            return View();
        }
    }
}