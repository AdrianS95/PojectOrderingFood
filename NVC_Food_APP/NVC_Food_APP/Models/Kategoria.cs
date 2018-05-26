using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class Kategoria
    {
        public int KategoriaID { get; set; }
        public string NazwaKategorii { get; set; }
        public string Opiskategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Jedzenie> Jedzenie {get; set;}
    }
}