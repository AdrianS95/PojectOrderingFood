using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PojectOrderingFood.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public AplicationUser IdKlient { get; set; }

        public List<Product> OrderedList { get; set; }

        public DateTime CreateOrder { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
            CreateOrder = DateTime.Now;
        }
    }
}
