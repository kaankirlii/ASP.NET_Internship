using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWeb.Models
{
    public class ProductModel
    {
        private List<Product> products;
        public ProductModel()
        {
            this.products = new List<Product>()
            {
                new Product
                {
                    ProductId="1",
                    ProImage="lenovoideapad3.jpg",
                    ProductName="Lenovo Ideapad 3",
                    Price=5200
                },
                new Product
                {
                    ProductId="2",
                    ProImage="hp245g8.jpg",
                    ProductName="HP 245 G8 AMD Ryzen 3",
                    Price=3600
                },
                new Product
                {
                    ProductId="3",
                    ProImage="oppoa73.jpg",
                    ProductName="Oppo A73",
                    Price=2660
                },
                new Product
                {
                    ProductId="4",
                    ProImage="samsunggalaxym12.jpg",
                    ProductName="Samsung Galaxy M12",
                    Price=2500
                },
                new Product
                {
                    ProductId="5",
                    ProImage="huaweiwatchfit.jpg",
                    ProductName="Huawei Watch Fit",
                    Price=702
                },
                new Product
                {
                    ProductId="6",
                    ProImage="huaweiwatchgt2.jpg",
                    ProductName="Huawei Watch GT2",
                    Price=1225
                }
            };
        } 
        public List<Product> FindAll()
        {
            return this.products;
        }
        public Product Find(string id)
        {
            return this.products.Single(p=>p.ProductId.Equals(id));
        }
    }
}