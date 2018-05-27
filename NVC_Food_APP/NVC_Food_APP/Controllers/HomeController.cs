using NVC_Food_APP.Models;
using NVC_Food_APP.ViewModel;
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
            var kategorie = db.Kategorie.ToList();
            var nowosci = db.Jedzenie.Where(x => x.Widoczny).OrderByDescending(x => x.DataDodania).Take(3).ToList();
            var najlepsze = db.Jedzenie.Where(x => x.Widoczny && x.DanieDnia).OrderBy(x => Guid.NewGuid()).Take(3).ToList();

            var vm = new HomeViewModel
            {
                Kategorie = kategorie,
                Nowosc = nowosci,
                Najlepsze = najlepsze,
            };

            return View(vm);
        }

        public ActionResult Oaplikacji()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }

        public ActionResult Pomoc()
        {
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