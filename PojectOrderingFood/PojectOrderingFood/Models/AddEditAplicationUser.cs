using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PojectOrderingFoodNVC.Models;
using PojectOrderingFood.BaseLogic;

namespace PojectOrderingFood.Models
{
    public class AddEditAplicationUser
    {
        [Required()]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "W imieniu nie moga znajdować się cyfry")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Remote("CheckExistingEmail", "Etap1CRUD", HttpMethod = "POST", ErrorMessage = "Email already exists")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public UserType? UserType { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)((?=.*[a-z])|(?=.*[A-Z])){2,}[a-zA-Z\d]{8,}$", ErrorMessage = "8znaków, min 2 litery, min 1 litera duz, min 1 cyfra")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string RepeatPassword { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string TelephoneNumber { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Address { get; private set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string PostCode { get; private set; }


        public AddEditAplicationUser()
        {

        }

        public AddEditAplicationUser(IAplicationLogic aplicationLogic, AplicationUser aplicationUser) //  
        {
            FirstName = aplicationUser.FirstName;
            LastName = aplicationUser.LastName;
            Email = aplicationUser.Email;
            UserType = aplicationUser.UserType;
            City = aplicationUser.City;
        }
        public AplicationUser conferenceUserFromViewModel(IAplicationLogic conferenceLogic, AddEditAplicationUser us)
        {
            return new AplicationUser()
            {
                FirstName = us.FirstName,
                LastName = us.LastName,
                Email = us.Email,
                Address = us.Address,
                PostCode = us.PostCode,
                City = us.City,
                TelephoneNumber = us.TelephoneNumber,
                UserType = us.UserType,
                Password = us.Password
            };
        }
    }
}