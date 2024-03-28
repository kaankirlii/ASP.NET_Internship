using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWeb.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProImage { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}