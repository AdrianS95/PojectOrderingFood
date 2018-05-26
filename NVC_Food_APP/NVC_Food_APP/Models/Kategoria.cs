using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class Kategoria
    {
        public int KategoriaID { get; set; }
        [Required(ErrorMessage = "Wprowadź Kategorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadź opis Kategorii")]
        [StringLength(100)]
        public string Opiskategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Jedzenie> Jedzenie {get; set;}
    }
}