using NVC_Food_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Kategoria> Kategorie { get; set; }
        public IEnumerable<Jedzenie> Nowosc { get; set; }
        public IEnumerable<Jedzenie> Najlepsze { get; set; }

    }
}