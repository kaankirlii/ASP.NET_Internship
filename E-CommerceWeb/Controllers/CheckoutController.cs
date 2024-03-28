using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_CommerceWeb.Models;

namespace E_CommerceWeb.Controllers
{
    public class CheckoutController : Controller
    {
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult OrderDone(string NameAndSurname,string AddressInfo,UInt64 CardNo)
        {
            List<Checkout> checkinfos = new List<Checkout>();
            checkinfos.Add(new Checkout()
            {
                NameAndSurname = NameAndSurname,
                AddressInfo = AddressInfo,
                CardNo = CardNo
            });
            return View(checkinfos);
        }
    }
}