using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PojectOrderingFoodNVC.Models
{
    public class Product
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImmageLink { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

    }
}