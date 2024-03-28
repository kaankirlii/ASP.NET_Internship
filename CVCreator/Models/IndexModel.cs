using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVCreator.Models
{
    public class IndexModel
    {
        //Personal and Contact Info
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string EMail{ get; set; }
        //Experience
        public string ExperienceYear { get; set; }
        public string Experience { get; set; }
        //Education
        public string EducationYear { get; set; }
        public string Education { get; set; }
        //Project
        public string ProjectYear { get; set; }
        public string Project { get; set; }
        //Skill
        public string Skill { get; set; }
        public string Level { get; set; }
        //Certificate
        public string CertificateYear { get; set; }
        public string Certificate { get; set; }
    }
}