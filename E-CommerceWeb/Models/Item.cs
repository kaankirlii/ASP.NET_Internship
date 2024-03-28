using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWeb.Models
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}