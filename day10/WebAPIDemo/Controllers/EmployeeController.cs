using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Model;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetEmployee")]
        public static  IEnumerable<Employee> Get()
        {
            var rnd = new Random();
            return  Enumerable.Range(1, 5).Select(index => new Employee
            {
                Id = rnd.Next(1, 100),              // rand Id b/w 1 and 99
                Name = $"Employee{rnd.Next(1, 100)}",  // rans name  "Employee7"
                Post = "Employee"
            })
            .ToArray();
        }
      
    }
}


