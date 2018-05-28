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
        [HttpPost]
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
        // AJAX: /ShoppingCart/RemoveFromCart/5
        //[HttpPost]
        //public ActionResult RemoveFromCart(int id)
        //{
        //    // Remove the item from the cart
        //    var cart = ShoppingCart.GetCart(this.HttpContext);

        //    // Get the name of the album to display confirmation
        //    string albumName = storeDB.Carts
        //        .Single(item => item.RecordId == id).Album.Title;

        //    // Remove from cart
        //    int itemCount = cart.RemoveFromCart(id);

        //    // Display the confirmation message
        //    var results = new ShoppingCartRemoveViewModel
        //    {
        //        Message = Server.HtmlEncode(albumName) +
        //            " has been removed from your shopping cart.",
        //        CartTotal = cart.GetTotal(),
        //        CartCount = cart.GetCount(),
        //        ItemCount = itemCount,
        //        DeleteId = id
        //    };
        //    return Json(results);
        //}

    }
}