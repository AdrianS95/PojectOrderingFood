using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko  { get; set; }
        public string Ulica { get; set; }
        public string  Miasto { get; set; }
        public string  KodPocztowy { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Uwagi { get; set; }
        public DateTime DataDowania { get; set; }
        public StanZamowienia StanZamówienia { get; set; }
        public decimal WartoscZamówienia { get; set; }

        List<PozycjaZamowienia> PozycjaZamowienia { get; set; }
    }
    public enum StanZamowienia
    {
        Nowe,
        zrealizowane
    }
}