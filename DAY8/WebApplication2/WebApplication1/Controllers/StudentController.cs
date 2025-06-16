using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {

        // Static list simulating a database
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Grade = "A" },
            new Student { Id = 2, Name = "Bob", Grade = "B" },
            new Student { Id = 3, Name = "Charlie", Grade = "C" }
        };

      

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = students.Max(s => s.Id) + 1;
            students.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student updated)
        {
            var student = students.FirstOrDefault(s => s.Id == updated.Id);
            if (student == null) return NotFound();

            student.Name = updated.Name;
            student.Grade = updated.Grade;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return View(student);// This loads Delete.cshtml
        }
        // POST: Perform deletion
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
                students.Remove(student);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(students);
        }
    }
}
