using demo.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace demo.Controllers
{
    public class StudentController : Controller
    {
        //attribute
        private readonly ApplicationDbContext context;

        //constructor (auto-generate : Alt+Enter => Generate constructor)
        public StudentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Students.ToList());
        }
    }
}
