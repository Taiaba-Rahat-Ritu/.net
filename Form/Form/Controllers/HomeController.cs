using Form.Models;
using System;
using System.Web.Mvc;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User u)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome");
            }

            return View(u);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            ViewBag.Name = Username;
            return View();
        }

        [HttpGet]
        public ActionResult Welcome()
        {
            return View();
        }
    }
}
