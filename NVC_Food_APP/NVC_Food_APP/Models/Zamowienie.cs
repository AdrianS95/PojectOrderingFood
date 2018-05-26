using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        [Required(ErrorMessage = "Wprowadź imię")]
        [StringLength(40)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwisko")]
        [StringLength(40)]
        public string Nazwisko  { get; set; }
        [Required(ErrorMessage = "Wprowadź ulice")]
        [StringLength(40)]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wprowadź miasto")]
        [StringLength(40)]
        public string  Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadź kod pocztowy")]
        [StringLength(40)]
        public string  KodPocztowy { get; set; }
        [Required(ErrorMessage = "Wprowadź telefon")]
        [StringLength(40)]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Wprowadź email")]
        [StringLength(40)]
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