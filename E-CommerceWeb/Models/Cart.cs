using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWeb.Models
{
    public class Cart
    {
        public List<Product> Product { get; set; }
        public int TotalPrice { get; set; }
    }
}