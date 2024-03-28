using ProductFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductFinder.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1,ProductName="Samsung Galaxy M12",Category="Smartphone",Price=2500},
            new Product{Id=2,ProductName="Lenovo IdeaPad 3",Category="Laptop",Price=5200},
            new Product{Id=3,ProductName="Huawei Watch GT2",Category="Smart Watch",Price=1225},
            new Product{Id=4,ProductName="Oppo A73",Category="Smartphone",Price=2660},
            new Product{Id=5,ProductName="Huawei Watch Fit",Category="Smart Watch",Price=702}
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
