using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NepFlixApp.Controllers
{
//    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            ViewBag.Message = "thuis met auth";
            return View();
        }
        public ActionResult Read()
        {
            ViewBag.Message = "iets lezen";
            return View();
        }
        public ActionResult Read3()
        {
            ViewBag.Message = "---iets lezen";
            return View();
        }

    }
}
