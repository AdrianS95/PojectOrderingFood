using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PojectOrderingFoodNVC.Models
{
    public class AplicationContext : DbContext
    {
        public DbSet<AplicationUser> AplicationUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public AplicationContext() : base("OrderingFoodDataBase")
        {
            
        }
    }
}