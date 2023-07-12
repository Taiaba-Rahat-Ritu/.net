using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Zero_Hunger.EF;
using Zero_Hunger.EF.Models;

namespace Zero_Hunger.Controllers
{
    public class Zero_HungerController : Controller
    {
        private ZeroContext db = new ZeroContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexC()
        {
            var collections = db.Collections.ToList();
            return View(collections);
        }

        [HttpGet]
        public ActionResult CreateC()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateC(Collection collection)
        {
            if (ModelState.IsValid)
            {
                db.Collections.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collection);
        }

        public ActionResult IndexE()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public ActionResult CreateE()
        {
            ViewBag.CollectionId = new SelectList(db.Collections, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult CreateE(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CollectionId = new SelectList(db.Collections, "Id", "Name", employee.CollectionId);
            return View(employee);
        }

        public ActionResult IndexD()
        {
            var distributions = db.Distributions.ToList();
            return View(distributions);
        }

        [HttpGet]
        public ActionResult CreateD()
        {
            ViewBag.CollectionId = new SelectList(db.Collections, "Id", "Name");
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult CreateD(Distribution distribution)
        {
            if (ModelState.IsValid)
            {
                var employee = db.Employees.Find(distribution.EmployeeId);
                if (employee != null)
                {
                    distribution.Employee = employee;
                    db.Distributions.Add(distribution);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.CollectionId = new SelectList(db.Collections, "Id", "Name", distribution.CollectionId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", distribution.EmployeeId);
            return View(distribution);
        }

        public ActionResult IndexR()
        {
            var restaurants = db.Restaurants.ToList();
            return View(restaurants);
        }

        [HttpGet]
        public ActionResult CreateR()
        {
            ViewBag.CollectionId = new SelectList(db.Collections, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult CreateR(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Restaurants.Add(restaurant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CollectionId = new SelectList(db.Collections, "Id", "Name", restaurant.CollectionId);
            return View(restaurant);
        }
    }
}
