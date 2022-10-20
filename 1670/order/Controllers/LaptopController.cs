using Microsoft.AspNetCore.Mvc;
using order.Data;
using System.Linq;

namespace order.Controllers
{
    public class LaptopController : Controller
    {
        protected ApplicationDbContext context;

        public LaptopController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Laptops.ToList());
        }
    }
}
