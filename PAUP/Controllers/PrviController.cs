using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAUP.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko veleučilište u Čakovcu";
            return View();
        }

        public ActionResult Druga()
        {
            ViewBag.Ustanova = "MEV";
            ViewData["Lokacija"] = "Čakovec";
           return View();
        }

        public ActionResult Treca(string poruka, int broj=1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }

        public ActionResult Student()
        {
            ViewBag.Ime = "Sibirski";
            ViewBag.Prezime = "Plavac";
            ViewBag.GodinaRodenja = "Od pocetka";
            return View(); // desni klik student, add view 
        }
    }
}