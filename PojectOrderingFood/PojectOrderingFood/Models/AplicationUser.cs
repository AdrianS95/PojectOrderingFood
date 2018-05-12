using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PojectOrderingFoodNVC.Models
{

    public enum UserType
    {
        Administrator,
        Klient,
    }

    public class AplicationUser
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string TelephoneNumber { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public UserType? TypeConference { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public DateTime CreateDate { get; set; }
        public UserType? UserType { get; internal set; }

        public AplicationUser()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
    }
}