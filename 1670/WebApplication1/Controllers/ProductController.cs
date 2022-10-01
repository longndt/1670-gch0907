using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        protected ApplicationDbContext context;
        public ProductController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            var products = context.Product.ToList();
            return View(products);
        }
    }
}
