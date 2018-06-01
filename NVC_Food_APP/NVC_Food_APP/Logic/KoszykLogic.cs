using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NVC_Food_APP.Models;

namespace NVC_Food_APP.Logic
{
    public class KoszykLogic
    {
        public static string KluczSesjiKoszyka = "KluczSesjiKoszyka";

        private JedzenieDbContext db;
        private IsesionMenager sesja;

        public KoszykLogic(IsesionMenager sesja, JedzenieDbContext db)
        {
            this.sesja = sesja;
            this.db = db;
        }

        public List<PozycjaKoszyka> PobierzKoszyk()
        {
            List<PozycjaKoszyka> koszyk;
            if (sesja.Get<List<PozycjaKoszyka>>(KluczSesjiKoszyka) == null)
            {
                koszyk = new List<PozycjaKoszyka>();
            }
            else
            {
                koszyk = sesja.Get<List<PozycjaKoszyka>>(KluczSesjiKoszyka) as List<PozycjaKoszyka>;
            }

            return koszyk;
        }

        public void DodajDoKoszyka(int jedzenieId)
        {
            var koszyk = PobierzKoszyk();
            var pozycja = koszyk.Find(x => x.PozJedzenie.JedzenieID == jedzenieId); // czy pozycja kopszyka istnieje

            if (pozycja != null)
            {
                pozycja.Ilosc += 1;
            }
            else
            {
                var jedzenieDoDodania = db.Jedzenie.Where(x => x.JedzenieID == jedzenieId).SingleOrDefault();

                if (jedzenieDoDodania != null)
                {
                    var nowaPozycja = new PozycjaKoszyka()
                    {
                        PozJedzenie = jedzenieDoDodania,
                        Ilosc = 1,
                        Wartosc = jedzenieDoDodania.Cena,
                    };
                    koszyk.Add(nowaPozycja);
                }
            }
            sesja.Set(KluczSesjiKoszyka, koszyk);
        }

        public int UsunZKoszyka(int jedzenieId)
        {
            var koszyk = PobierzKoszyk();
            var pozycjaKoszyka = koszyk.Find(x => x.PozJedzenie.JedzenieID == jedzenieId);
            if (pozycjaKoszyka != null)
            {
                if (pozycjaKoszyka.Ilosc > 1)
                {
                    pozycjaKoszyka.Ilosc--;
                    return pozycjaKoszyka.Ilosc;
                }
                else
                {
                    koszyk.Remove(pozycjaKoszyka);
                }
            }
            return 0;
        }
        public decimal PobierzWartoscKoszyka()
        {
            var koszyk = PobierzKoszyk();
            return koszyk.Sum(k => (k.Ilosc * k.Wartosc));
        }

        public int PobierzIloscPozycjiKoszyka()
        {
            var koszyk = PobierzKoszyk();
            int ilosc = koszyk.Sum(k => k.Ilosc);
            return ilosc;
        }

        public Zamowienie UtworzZamowienie(Zamowienie Nowe, string userId)
        {
            var koszyk = PobierzKoszyk();
            Nowe.DataDowania = DateTime.Now;
            Nowe.UserId = userId;

            db.Zamowienia.Add(Nowe);

            if (Nowe.PozycjaZamowienia == null)
                Nowe.PozycjaZamowienia = new List<PozycjaZamowienia>();

            decimal koszykWartosc = 0;

            foreach (var koszykElement in koszyk)
            {
                var nowaPozycjaZamowienia = new PozycjaZamowienia()
                {
                    JedzenieId = koszykElement.PozJedzenie.JedzenieID,
                    Ilosc = koszykElement.Ilosc,
                    CenaZakupu = koszykElement.Wartosc
                };

                koszykWartosc += (koszykElement.Ilosc * koszykElement.Wartosc);
                Nowe.PozycjaZamowienia.Add(nowaPozycjaZamowienia);
            }

            Nowe.WartoscZamówienia = koszykWartosc;     //Wywalic polskie znaki 
            db.SaveChanges();

            return Nowe;
        }

        public void PustyKoszyk()
        {
            sesja.Set<List<PozycjaKoszyka>>(KluczSesjiKoszyka, null);
        }
    }
}