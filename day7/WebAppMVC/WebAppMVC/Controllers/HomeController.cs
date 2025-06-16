using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // https://localhost:7195/ or https://localhost:7195/home/index
        public IActionResult Index() 
        {
            return View();
        }

        // https://localhost:7195/home/justdotest
        public string JustDoTest() { return "JustToTest() method"; }

        public IActionResult MyNewAction()
        {
            return View();
        }
    }
}
