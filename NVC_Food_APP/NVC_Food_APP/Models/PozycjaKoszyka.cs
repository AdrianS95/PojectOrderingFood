using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class PozycjaKoszyka
    {
        public Jedzenie PozJedzenie { get; set; }
        public int Ilosc { get; set; }
        public decimal Wartosc { get; set; }
    }
}