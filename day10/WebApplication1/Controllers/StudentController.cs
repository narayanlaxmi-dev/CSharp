using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[Route("Student")] // https://localhost:7277/sTUDENT 
    public class StudentController : Controller

    {
        [Route("")] // DEFAULT ROUTING  https://localhost:7277/
        [Route("NarayanStudent")]
        public IActionResult Index()
        {
            IList<Student> students = new List<Student>
            {
                new Student { StudentId = 1, FirstName = "Nara", LastName="Patil" },
                new Student { StudentId =2, FirstName="Yana", LastName="Patil"},
                new Student { StudentId =0, FirstName="Shiva", LastName="Om"},
                new Student { StudentId =4, FirstName="Hanu", LastName="Anjana"}
            };

            IList<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact { Email= "Nara@gmail.com", PhoneNumber=213415432});
            contacts.Add(new Contact { Email = "Yana@gmail.com", PhoneNumber = 893728742 });
            contacts.Add(new Contact { Email = "Shiva@gmail.com", PhoneNumber = 986374290 });
            contacts.Add(new Contact { Email = "Hanu@gmail.com", PhoneNumber = 813415752 });

            IList<Enrollment> enrollments = new List<Enrollment>();
            enrollments.Add(new Enrollment
            {
                CourseName = ".net",
                EnrollmentDate = new DateOnly(2025, 05, 1)  // year=2025, month=5 (May), day=1
            });
            enrollments.Add(new Enrollment{CourseName = "React",EnrollmentDate = new DateOnly(2025, 06, 13)});
            enrollments.Add(new Enrollment { CourseName = "Java", EnrollmentDate = new DateOnly(2025, 07, 15) });

            StudentPageViewModel viewModel = new StudentPageViewModel
            {
                Students = students,
                Contacts = contacts,
                Enroll = enrollments
            };

            return View(viewModel);
        }
    }
}
