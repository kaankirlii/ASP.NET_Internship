using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWeb.Models
{
    public class Checkout
    {
        public string NameAndSurname { get; set; }
        public string AddressInfo { get; set; }
        public UInt64 CardNo { get; set; }
    }
}