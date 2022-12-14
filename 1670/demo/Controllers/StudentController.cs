using demo.Data;
using demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [Route("/")]
        public IActionResult Index()
        {
            return View(context.Students.ToList());
        }

        public IActionResult List()
        {
            return View(context.Students.ToList());
        }

        [Authorize(Roles = "Administrator")]
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

                //gửi thông báo về trang Index
                //bắt buộc dùng TempData để có thể gửi dữ liệu về View nếu return RedirectToAction
                TempData["Message"] = "Delete student successfully !";

                //quay trở lại trang index sau khi thành công
                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Detail(int id)
        {
            var student = context.Students
                                 .Include(s => s.University)
                                 .FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Add ()
        {
            //lấy ra dữ liệu từ bảng University và lưu vào list
            var universities = context.Universities.ToList();
            //dữ liệu đẩy vào ViewBag để gọi đến trong View
            ViewBag.Universities = universities;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            //nếu người dùng nhập đủ và đúng thông tin vào form
            //thì dữ liệu sẽ được add vào database
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                TempData["Message"] = "Add student successfully !";
                return RedirectToAction("index");
            }
            else  
            //ngược lại nếu người dùng nhập sai thì quay ngược trở lại form để add
            //Lưu ý: cần tạo và giá trị cho biến ViewBag => tránh bị lỗi object null
            {
                ViewBag.Universities = context.Universities.ToList();
                return View(student);
            }
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            //lấy ra dữ liệu từ bảng University và lưu vào list
            var universities = context.Universities.ToList();
            //dữ liệu đẩy vào ViewBag để gọi đến trong View
            ViewBag.Universities = universities;
            return View(context.Students.Find(id));
        }

        [HttpPost]
        public IActionResult Edit (Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Update(student);
                context.SaveChanges();
                TempData["Message"] = "Edit student successfully !";
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.Universities = context.Universities.ToList();
                return View(student);
            }
        }

        public IActionResult SortNameAsc ()
        {
            return View("Index",context.Students.OrderBy(s => s.Name).ToList());
        }

        public IActionResult SortNameDesc ()
        {
            return View("Index",context.Students.OrderByDescending(s => s.Name).ToList());
        }

        [HttpPost]
        public IActionResult Search (string keyword)
        {
            var students = context.Students.Where(s => s.Name.Contains(keyword)).ToList();
            if (students.Count == 0)
            {
                TempData["Message"] = "No student found";
            }
            return View("Index", students);
        }
    }
}
