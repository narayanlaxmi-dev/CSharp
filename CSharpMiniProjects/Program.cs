using System;

namespace CSharpMiniProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello World";
            Console.WriteLine(test.CountVowels());
            Console.WriteLine(test.AddSuffix("_done"));

            Console.WriteLine(MathHelper.Add(5, 3));
            Console.WriteLine(MathHelper.Subtract(5, 3));
            Console.WriteLine(MathHelper.Multiply(5, 3));
            Console.WriteLine(MathHelper.Divide(10, 2));

            Console.WriteLine(GreetingHelper.GetGreeting());

            Book myBook = new Book("1984", "George Orwell");
            myBook.PrintDetails();

            Rectangle rect = new Rectangle();
            rect.PrintArea();

            Product prod1 = new Product("Phone", 699.99);
            Product prod2 = new Product(prod1);
            prod2.PrintDetails();

            Student student = new Student { Name = "Alice", Class = "10A", RollNumber = 23 };
            Console.WriteLine($"
Student: {student.Name}, Class: {student.Class}, Roll No: {student.RollNumber}");

            Temperature temp = new Temperature();
            temp.Value = 60; // Invalid
            temp.Value = 25; // Valid

            Circle circle = new Circle { Radius = 3 };
            Console.WriteLine($"Area of circle: {circle.Area}");
        }
    }
}