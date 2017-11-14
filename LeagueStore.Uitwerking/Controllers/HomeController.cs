using LeagueStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeagueStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HelloWorld()
        {
            return Content("Hello world");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            ViewBag.Titel = "SUPER MEGA KORTING";
            ViewBag.Bericht = "Alles nu 80% korting! Opruim weken bij de League store. ";
            ViewBag.DatumVan = DateTime.Now.ToShortDateString();
            ViewBag.DatumTot = DateTime.Now.AddDays(7).ToShortDateString();

            return View();
        }

        public ActionResult Contact()
        {
            using (var context = new MyContext())
            {
                List<Employee> data = context.Employees.ToList();

                //geef de data mee aan het model
                return View(data);
            } 
        }

        public ActionResult Reset()
        {
            using (var context = new MyContext())
            {
        
                context.Database.ExecuteSqlCommand("DROP TABLE Products");
                context.Database.ExecuteSqlCommand("DROP TABLE Bundles");
                context.Database.ExecuteSqlCommand("DROP TABLE Employees");

                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}