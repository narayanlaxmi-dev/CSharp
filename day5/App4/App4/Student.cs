namespace App4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double percentage { get; set; }
        
        public Student() { }
        public Student(int Id, string Name,double percentage) {
            this.Id = Id;
            this.Name = Name;
            this.percentage = percentage;
        }
    }
}