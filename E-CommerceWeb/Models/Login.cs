using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceWeb.Models
{
    public class Login
    {
        [Required]
        [DisplayName("User name:")]
        public string Username { get; set; }
        [Required]
        [DisplayName("Password:")]
        public string Password { get; set; }
        public bool RememberUser { get; set; }
    }
}