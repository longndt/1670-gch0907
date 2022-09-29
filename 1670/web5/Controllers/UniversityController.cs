using Microsoft.AspNetCore.Mvc;
using web5.Models;

namespace web5.Controllers
{
    public class UniversityController : Controller
    {
        //render ra view form để nhập liệu
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //xử lý dữ liệu nhập từ form
        [HttpPost]
        public IActionResult Index(University uni)
        {    
            return View("Result", uni);
        }
    }
}
