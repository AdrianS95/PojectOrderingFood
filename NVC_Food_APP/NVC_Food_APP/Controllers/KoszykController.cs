using NVC_Food_APP.Logic;
using NVC_Food_APP.Models;
using NVC_Food_APP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVC_Food_APP.Controllers
{
    public class KoszykController : Controller
    {
        private KoszykLogic KoszykLogic;
        private IsesionMenager sesja { get; set; }
        private JedzenieDbContext db;

        public KoszykController()
        {
            db = new JedzenieDbContext();
            sesja = new SessionMenager();
            KoszykLogic = new KoszykLogic(sesja, db);
        }

    // GET: Koszyk
    public ActionResult Index()
        {
            var pozycjeKoszyka = KoszykLogic.PobierzKoszyk();
            var cena = KoszykLogic.PobierzWartoscKoszyka();
            KoszykViewModel koszyk = new KoszykViewModel()
            {
                PozycjaKoszyka = pozycjeKoszyka,
                CenaCalkowita = cena,
            };
            return View(koszyk);
        }
        public ActionResult DodajDoKoszyka(int id)
        {
            KoszykLogic.DodajDoKoszyka(id);
            return RedirectToAction("Index");
        }

        public int IleMamWKoszyku()
        {
            return KoszykLogic.PobierzIloscPozycjiKoszyka();
        }
        public ActionResult UsunZKoszyka(int JedzenieID)
        {
            int iloscPozycji = KoszykLogic.UsunZKoszyka(JedzenieID);
            int iloscPozycjiKoszyka = KoszykLogic.PobierzIloscPozycjiKoszyka();
            decimal wartoscKoszyka = KoszykLogic.PobierzWartoscKoszyka();

            var wynik = new KoszykUsuwanieViewModel
            {
                IdPozycjiUsuwanej = JedzenieID,
                IloscPozycjiUsuwanej = iloscPozycji,
                KoszykCenaCalkowita = wartoscKoszyka,
                KoszykIloscPozycji = iloscPozycjiKoszyka,
            };
            return Json(wynik);
        }
    }
}