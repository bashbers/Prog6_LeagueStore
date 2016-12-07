using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeagueStore.Controllers
{
    public class HomeController : Controller
    {
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
    }
}