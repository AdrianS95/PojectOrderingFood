using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PojectOrderingFood.Models
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
