using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeagueStore.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Een actie die geen HTMl maar gewoon een berichtje terug stuurt
        /// </summary>
        /// <returns></returns>
        public ActionResult HelloWorld()
        {
            return Content("Hello world");
        }

        /// <summary>
        /// Een actie die een HTML pagina terug stuurt
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Een actie die een HTML pagina terug stuurt met data uit de ViewBag
        /// </summary>
        /// <returns></returns>
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