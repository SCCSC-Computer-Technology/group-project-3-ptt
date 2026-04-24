using Microsoft.AspNetCore.Mvc;

namespace Pantreats.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }
    }
}
