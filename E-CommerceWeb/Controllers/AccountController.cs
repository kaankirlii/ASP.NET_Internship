using E_CommerceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceWeb.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            string uname = collection.Get("uname");
            string pass = collection.Get("pass");

            if (uname=="user123" && pass =="pass123")
            {
                return View("Index");
            }
            else
            {
                return View("Login");
            } 
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}