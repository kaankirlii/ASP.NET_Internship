using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_CommerceWeb.Models;

namespace E_CommerceWeb.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.FindAll();
            return View();
        }
    }
}