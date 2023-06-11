using Company_lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace Company_lab2.Controllers
{
    public class companyController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "ABC Company!";
            ViewBag.msg = "Welcome to HomePage of ABC Company.";
            return View();
        }
        public ActionResult Services()
        {
            var s1 = new Services()
            {
                Title = "Service 1",
                Description = "Web Development"
            };

            var s2 = new Services()
            {
                Title = "Service 2",
                Description = "App Development"
            };

            var s3 = new Services()
            {
                Title = "Service 3",
                Description = "Graphics Designing"
            };

            var s4 = new Services()
            {
                Title = "Service 4",
                Description = "abc"
            };

            Services[] services = new Services[] { s1, s2, s3, s4 };

            return View(services);
        }
        public ActionResult Teams()
        {
            ViewBag.Name = "ABC Company!";
            ViewBag.msg = "Welcome to Teams and Members Information";

            var t1 = new Teams()
            {
                Title = "Team 1",
                name = "Web Development Team",
                member = 4
            };
            var t2 = new Teams()
            {
                Title = "Team 2",
                name = "App Development Team",
                member = 4
            };
            var t3 = new Teams()
            {
                Title = "Team 3",
                name = "Graphics Designing Team",
                member = 4
            };
            var t4 = new Teams()
            {
                Title = "Team 4",
                name = "abc Team",
                member = 4
            };

            Teams[] teams = new Teams[] { t1, t2, t3, t4 };
            return View(teams);
        }

        public ActionResult Contact()
        {
            ViewBag.Name = "ABC Company!";
            ViewBag.msg = "Contact Form.";
            return View();
        }
    }
}