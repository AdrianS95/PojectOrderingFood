using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class Jedzenie
    {
        public int JedzenieID { get; set; }
        public int KategoriaID { get; set; }
        [Required(ErrorMessage ="Wprowadź Nazwę")]
        [StringLength(100)]
        public string NazwaJedzenia { get; set; }
        [Required(ErrorMessage = "Wprowadź Nazwę")]
        [StringLength(500)]
        public string OpisJedzenia { get; set; }
        public DateTime DataDodania { get; set; }
        [StringLength(150)]
        public string PlikObrazek { get; set; }
        public decimal Cena { get; set; }
        public bool DanieDnia { get; set; }
        public bool Widoczny { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}