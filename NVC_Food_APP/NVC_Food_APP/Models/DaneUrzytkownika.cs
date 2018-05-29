using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class DaneUrzytkownika
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        [EmailAddress(ErrorMessage ="Błądny adres")]
        public string Email { get; set; }
        public string Telefon { get; set; }



    }
}