using System;
using System.Collections;
using System.Collections.Generic;

namespace order.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public double OrderPrice { get; set; }

        public int LaptopId { get; set; }
        public Laptop Laptop { get; set; }
    }
}
