using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVCreator.Models;
using Rotativa;

namespace CVCreator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CV(string NameSurname,string Phone,string EMail,string ExperienceYear,
            string Experience,string EducationYear,string Education,string ProjectYear,string Project,
            string Skill,string Level,string CertificateYear,string Certificate)
        {
            List<IndexModel> infos = new List<IndexModel>();
            infos.Add(new IndexModel() {
                NameSurname = NameSurname,
                Phone = Phone,
                EMail = EMail,
                ExperienceYear = ExperienceYear,
                Experience = Experience,
                EducationYear = EducationYear,
                Education = Education,
                ProjectYear = ProjectYear,
                Project = Project,
                Skill = Skill,
                Level = Level,
                CertificateYear = CertificateYear,
                Certificate = Certificate
            });  
            return View(infos);
        }
    }
}