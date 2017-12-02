using Quizzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quizzer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            using (var context = new Context())
            {
                var projects = context.Project.ToList();
                foreach (var project in projects)
                {
                    var a = project.Description;
                    ViewBag.Message = a;
                }

            }

            return View();
        }
    }
}