using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using NVC_Food_APP.Logic;
using NVC_Food_APP.Models;
using NVC_Food_APP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static NVC_Food_APP.App_Start.IdentityConfig;

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
        public async Task<ActionResult> Zaplac()
        {
            var name = User.Identity.Name;

            if (Request.IsAuthenticated)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());

                var zamowienie = new Zamowienie
                {
                    Imie = user.DaneUzytkownika.Imie,
                    Nazwisko = user.DaneUzytkownika.Nazwisko,
                    Adres = user.DaneUzytkownika.Adres,
                    Miasto = user.DaneUzytkownika.Miasto,
                    KodPocztowy = user.DaneUzytkownika.KodPocztowy,
                    Email = user.DaneUzytkownika.Email,
                    Telefon = user.DaneUzytkownika.Telefon
                };
                return View(zamowienie);
            }
            else
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Zaplac", "Koszyk") });
        }

        [HttpPost]
        public async Task<ActionResult> Zaplac(Zamowienie zamowienieSzczegoly)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();

                var newOrder = KoszykLogic.UtworzZamowienie(zamowienieSzczegoly, userId);

                var user = await UserManager.FindByIdAsync(userId);
                TryUpdateModel(user.DaneUzytkownika);
                await UserManager.UpdateAsync(user);

                KoszykLogic.PustyKoszyk();

                return RedirectToAction("Potwierdzenie");
            }
            else
                return View(zamowienieSzczegoly);
        }
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        public ActionResult Potwierdzenie()
        {
            var name = User.Identity.Name;
            return View();
        }
    }
}