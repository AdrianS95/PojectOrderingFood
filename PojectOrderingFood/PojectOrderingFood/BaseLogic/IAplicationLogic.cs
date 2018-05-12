using PojectOrderingFoodNVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PojectOrderingFood.BaseLogic
{
    public interface IAplicationLogic
    {
        void AddAplicationUser(AplicationUser aplicationUser);
        void Delete(Guid Id);
        void Edit(Guid Id, AplicationUser conferenceUser);
        AplicationUser GetAplicationUser(Guid Id);
        List<AplicationUser> GetAplicationUser();
        List<Guid> GetGuid();
        void EditPassword(Guid Id, string newPassword);
    }
}