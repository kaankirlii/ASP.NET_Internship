using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_CommerceWeb.Models;

namespace E_CommerceWeb.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(string id)
        {
            ProductModel productModel = new ProductModel();
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item 
                {
                    Product = productModel.Find(id), 
                    Quantity = 1
                });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = IsExist(id);
                if (index!=-1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item {Product = productModel.Find(id), Quantity = 1});
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index","Cart");
        }
        public ActionResult RemoveFromCart(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int index = IsExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index", "Cart");
        }
        private int IsExist(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.Equals(id))
                    return i;
            }
            return -1;
        }
    }
}