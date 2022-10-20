using Microsoft.AspNetCore.Mvc;
using order.Data;
using order.Models;

namespace order.Controllers
{
  
    public class OrderController : Controller
    {
        protected ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult MakeOrder(int laptop, int quantity)
        {
            var order = new Order();
            order.OrderQuantity = quantity;
            order.LaptopId = laptop;
            context.Orders.Add(order);
            context.SaveChanges();
            return View();
        }
    }
}
