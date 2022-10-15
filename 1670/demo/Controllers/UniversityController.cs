using demo.Data;
using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net.Mime;

namespace demo.Controllers
{
    public class UniversityController : Controller
    {
        private readonly ApplicationDbContext context;

        public UniversityController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var universities = context.Universities.ToList();
            return View(universities);
        }

        public IActionResult Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var university = context.Universities
                                    .Include(u => u.Students)
                                    .FirstOrDefault(u => u.Id == id);
            //Note: khi muốn truy xuất dữ liệu của bảng B từ bảng A
            //thì cần sử dụng Include kết hợp với FirstOrDefault
            //còn nếu chỉ truy xuất thông tin id đơn thuần thì sử dụng
            //Find hoặc FirstOrDefault đều được
            return View(university);
        }

        public IActionResult Remove (int id)
        {
            var university = context.Universities.Find(id);
            context.Universities.Remove(university);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add (University university)
        {
            //kiểm tra thông tin nhập vào từ form
            if (ModelState.IsValid)
            {
                //nếu hợp lệ thì add vào db
                context.Universities.Add(university);
                //lưu thay đổi vào db
                context.SaveChanges();
                //return về trang index
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            //nếu không hợp lệ thì quay ngược về form 
            return View(university);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var university = context.Universities.Find(id);
            return View(university);
        }

        [HttpPost]
        public IActionResult Edit (University university)
        {
            //kiểm tra thông tin nhập vào từ form
            if (ModelState.IsValid)
            {
                //nếu hợp lệ thì cập nhật vào db
                context.Universities.Update(university);
                //lưu thay đổi vào db
                context.SaveChanges();
                //return về trang index
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            //nếu không hợp lệ thì quay ngược về form 
            return View(university);
        }
    }
}
