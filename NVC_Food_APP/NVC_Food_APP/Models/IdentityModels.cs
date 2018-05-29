using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace NVC_Food_APP.Models
{
    public class IdentityModels
    {
        public class ApplicationUser : IdentityUser
        {
            public virtual ICollection<Zamowienie> Zamówienia { get; set; }

            public DaneUrzytkownika daneUrzytkownika { get; set; }


            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
            {
                // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Dodaj tutaj niestandardowe oświadczenia użytkownika
                return userIdentity;
            }
        }
    }
}