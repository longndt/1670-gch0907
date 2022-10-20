using System.Collections;
using System.Collections.Generic;

namespace order.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
