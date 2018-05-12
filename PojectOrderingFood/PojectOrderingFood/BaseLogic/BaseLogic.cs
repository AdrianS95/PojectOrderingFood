using PojectOrderingFoodNVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PojectOrderingFood.BaseLogic
{
    public class BaseLogic : IAplicationLogic
    {

        AplicationContext _context;

        public BaseLogic()
        {
            _context = new AplicationContext();
        }

        public void AddOrder(Order city)
        {
            _context.Order.Add(city);
            _context.SaveChanges();
        }

        public void AddAplicationUser(AplicationUser aplicationUser)
        {
            _context.AplicationUser.Add(aplicationUser);
            _context.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _context.AplicationUser.Remove(GetAplicationUser(Id));
            _context.SaveChanges();
        }

        public void Edit(Guid Id, AplicationUser aplicationUser)
        {
            var cu = GetAplicationUser(Id);
            cu.FirstName = aplicationUser.FirstName;
            cu.LastName = aplicationUser.LastName;
            cu.Email = aplicationUser.Email;
            cu.TelephoneNumber = aplicationUser.TelephoneNumber;
            cu.PostCode = aplicationUser.PostCode;
            cu.TypeConference = aplicationUser.TypeConference;
            cu.City = aplicationUser.City;
            cu.Address = aplicationUser.Address;
            _context.SaveChanges();
        }

        public List<Order> GetCities()
        {
            return _context.Order.ToList();
        }

        public void EditPassword(Guid Id, string newPassword)
        {
            GetAplicationUser(Id).Password = newPassword;
            _context.SaveChanges();
        }

        public Order GetOrder(Guid Id)
        {
            return _context.Order.Find(Id);
        }

        public AplicationUser GetAplicationUser(Guid Id)
        {
            return _context.AplicationUser.Find(Id);
        }

        public List<AplicationUser> GetAplicationUser()
        {
            return _context.AplicationUser.ToList();
        }

        public List<Guid> GetGuid()
        {
            throw new NotImplementedException();
        }
    }
}