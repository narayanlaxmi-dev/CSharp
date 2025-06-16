using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
