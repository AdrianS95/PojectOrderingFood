using NVC_Food_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVC_Food_APP.Controllers
{
    public class HomeController : Controller
    {
        public JedzenieDbContext db = new JedzenieDbContext();

        public ActionResult Index()
        {
            Kategoria kategoria = new Kategoria { NazwaKategorii = "aspn.net mvc", NazwaPlikuIkony = "aspNetMvc.png", Opiskategorii = "coś" };
            db.Kategorie.Add(kategoria);
            db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}