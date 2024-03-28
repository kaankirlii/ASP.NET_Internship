using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebsiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "This page is About page.";

            return View();
        }
        public ActionResult Skills()
        {
            ViewBag.Message = "This page is Skills page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact with me";

            return View();
        }
    }
}