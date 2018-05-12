using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PojectOrderingFoodNVC.Models
{
    public class AplicationContext
    {
        public DbSet<AplicationUser> AplicationUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public AplicationContext() : base("OrderingFoodDataBase")
        {

        }
    }
}