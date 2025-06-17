namespace EmployeeCRUD.Model
{
    public class Employee
    {
        public int Id { get; set; } // Primary key
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Email { get; set; }
        public decimal Salary { get; set; }
    }
}
