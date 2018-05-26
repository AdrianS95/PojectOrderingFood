using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class Jedzenie
    {
        public int JedzenieID { get; set; }
        public int KategoriaID { get; set; }
        public DateTime DataDodania { get; set; }
        public string PlikObrazek { get; set; }
        public decimal Cena { get; set; }
        public bool DanieDnia { get; set; }
        public bool Widoczny { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}