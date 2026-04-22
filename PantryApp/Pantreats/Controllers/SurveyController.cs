using Microsoft.AspNetCore.Mvc;

namespace Pantreats.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
