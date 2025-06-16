using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        // https://localhost:7195/student/index
        public IActionResult Index()
        {
            //IList<string> students = new List<string>();
            //students.Add("Nara");
            //students.Add("Yana");
            //students.Add("Shakti");
            //students.Add("Shiv");
            //students.Add("Hanu");

            // i declare student class
            IList<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Nara" });
            students.Add(new Student { Id = 2, Name = "Yana" });
            students.Add(new Student { Id = 3, Name = "Shakti" });
            students.Add(new Student { Id = 4, Name = "Shiv" });
            students.Add(new Student { Id = 5, Name = "Hanu" });

            //ViewBag.STUDENTSLIST = students;    // internally it used in ViewData or
            //ViewData["studentsList"] = students; return view();
            // recomended way strongly typed view


            return View(students);
        }
    }
}
