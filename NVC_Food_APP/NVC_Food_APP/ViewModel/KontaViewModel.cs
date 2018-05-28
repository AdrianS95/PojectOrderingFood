using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.ViewModel
{
    public class LogowanieViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
    }
    public class RejestracjaViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "{0} musi mieć co najmniej {2} znaków.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = " Hasło ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdz Hasło ")]
        [Compare("Password", ErrorMessage = "Hasło i potwierdzenie hasła nie pasują do siebie.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string Adres { get; set; }


        [Required(ErrorMessage = "Pole wymagane")]
        public string Miasto { get; set; }


        [Required(ErrorMessage = "Pole wymagane")]
        public string KodPocztowy { get; set; }












    }
}