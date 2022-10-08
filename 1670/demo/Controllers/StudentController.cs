using demo.Data;
using demo.Models;
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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                //nếu id không tìm thấy thì trả về not found
                return NotFound();
            }
            else
            {
                //tìm ra object student có id được yêu cầu
                var student = context.Students.Find(id);
                //xóa object student vừa tìm thấy
                context.Students.Remove(student);
                //lưu lại thay đổi trong db
                context.SaveChanges();
                //quay trở lại trang index sau khi thành công
                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Detail(int id)
        {
            var student = context.Students.Find(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Add ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("index");
        } 
    }
}
