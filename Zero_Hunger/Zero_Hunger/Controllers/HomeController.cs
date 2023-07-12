using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zero_Hunger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Collection()
        {
            ViewBag.Message = "Here is the FOOD Collection List";

            return View();
        }

        public ActionResult Distribution()
        {
            ViewBag.Message = "Here is the FOOD Distribution List";

            return View();
        }
    }
}