namespace StudentProfilePage_exercise.Models
{
    public class StudentPageViewModel
    {
        public IList<Student> Students { get; set; }
        public IList<Contact> Contacts { get; set; }
        public IList<Enrollment> Enroll { get; set; }
    }
}
