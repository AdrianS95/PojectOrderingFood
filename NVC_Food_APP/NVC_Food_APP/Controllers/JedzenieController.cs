using NVC_Food_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVC_Food_APP.Controllers
{
    public class JedzenieController : Controller
    {
        private JedzenieDbContext db = new JedzenieDbContext();
        // GET: Jedzenie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista(string nazwaKategorii)
        {
            var kategorie = db.Kategorie.Include("Jedzenie").Where(x => x.NazwaKategorii.ToUpper() == nazwaKategorii.ToUpper()).Single();
            var jedzenie = kategorie.Jedzenie.ToList();
            return View(jedzenie);
        }

        public ActionResult Szczeguly(string id)
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult MenuKategorie()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_MenuKategorie", kategorie);
        }


    }
}