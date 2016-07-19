using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobAppMgmt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Status()
        {
            ViewBag.Message = "The companies you have applied so far are listed below: ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to reach out to us!";

            return View();
        }
    }
}