using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App4
{
    internal class Program
    {
        delegate void printMsg(string n);
        static void Main(string[] args)
        {
            /*
                // idisposable ka code using block me aayega because it auto called Disposed
                using (SimpleResource resource = new SimpleResource())
                {


                    // doing some coding 
                    // at the and dispose unmanage component/reference
                    resource.Dispose();
                */

            /*
            // generics Type
            Electronic laptop = new Electronic(1,"Laptop","Asus Rog",50000);
            Electronic moblie = new Electronic(1, "Mobile", "OnePlus 10Pro", 2000);
            Electronic headphone = new Electronic(1, "HeadPhone", "Sony", 50000);
            Electronic Car = new Electronic(1, "Electronic Mini Car", "Toyify 4x4 Big ", 50000);

          
            Manager<Electronic> manager = new Manager<Electronic>();

            // Add the item
            manager.AddItem(new Electronic(1, "Laptop", "Asus Rog", 50000));
            manager.AddItem(moblie);
            manager.AddItem(new Electronic(1, "Electronic Mini Car", "Toyify 4x4 Big ", 50000));
            manager.PrintItem(e => e.Display());
            manager.RemoveItem(1);
           
            manager.PrintItem(e => e.Display());
            Console.WriteLine("Press any key to exit...");*/

            /*
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Dictionary<int, string> students = new Dictionary<int, string>();
            students[1] = "Nara";
            students[2] = "Shiva";
            students[3] = "Yana";
            foreach (var i in students) {
                Console.WriteLine($"Key: {i.Key} Name: {i.Value} ");
            }


            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.23);
            foreach (var i in arrayList) 
            Console.WriteLine(i);           
            */

            /*
            Thread t = new Thread(Printno);
            t.Start();

            //t.Join(); // wait till thread complete there task

            Console.WriteLine("Main Thread");

            //Thread t1 = new Thread(PrintMessage);
            //t1.Start("Hello from thread t1!");

            ThreadPool.QueueUserWorkItem(PrintMessage);
            ThreadPool.QueueUserWorkItem(PrintMessage);
            Console.WriteLine("ManageThread by ID: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("current thread name: " + Thread.CurrentThread.Name);

            string myMessage = "Hello from thread pool!";
            ThreadPool.QueueUserWorkItem(PrintMessage1, myMessage);  */

            /*
            Thread wait = new Thread(PrintMessage);
            wait.Start("Thread 1 started");
            //ThreadPool.QueueUserWorkItem(Printno);
            Thread download = new Thread(Printno);
            download.Start();
            wait.Join();
            download.Join();
            
            //var task1 = Task.Run(() => PrintMessage("Thread 1 started"));
            //var task2 = Task.Run(() => Printno(""));
            //Task.WaitAll(task1, task2);

            Console.WriteLine("All Files successfully downloaded");     */

            /*
            printMsg msg = delegate (string n)
            {
                Console.WriteLine("Hello World Anonymous func"+n);
            };
            
            msg("  :- value pass");

            Action msg1 = delegate ()
            {
                Console.WriteLine("Action delegate Anonymous func");
            };
            msg1();

            //   para1  para2 return 
            Func<double, int, double> add = (a, b) => a + b;
            Console.WriteLine(add(5.5,3));


            Func<double, int, double> mult = (a, b) => { return a* b; };
            Console.WriteLine(mult(5.5, 3));
            Action greet = () => { Console.WriteLine("Lambda Delegate function"); };
            greet();    */

            // var support any datatype it check right side what return no is int and num is list 
            /*
            //var no = 123; // primitive dt
            var num = new List<int> { 1, 2, 3, 4, 5 }; // collection dt non primitive
            var even = num.Where(n => n % 2 == 0);

            foreach (var n in even)
            {
                Console.WriteLine(n);
            }
            var name = new List<string> { "Nara", "yana", "Shiva" }; // collection dt non primitive
            var sortName = name.OrderBy(n => n);

            foreach (var v in sortName)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n----------linQ DB-----------\n");
     

            List<Student> students = new List<Student> {
            new Student{ Id=1, Name="Narayan ", percentage = 90},
            new Student{ Id=2,Name="Yana ", percentage =50},
            new Student{ Id=3,Name="Hel ", percentage = 80.12}
            }; var topStudent = from s in students
                                where s.percentage > 80
                                select s;

            foreach (var student in topStudent)
            {
                Console.WriteLine($"Name: {student.Name} MARKS {student.percentage}> 80%");
            }

            // linq ended */

            // TUPLE return multiple properties in one 
            /*
            Tuple<int, string> Tupleclass = new Tuple<int, string>(1,"hello");// class using tuple
            Console.WriteLine(Tupleclass.Item1);
            Console.WriteLine(Tupleclass.Item2);


            // tuple using literal
            var person = (Id: 1 , Name:"NA");
            Console.WriteLine(person);
            Console.WriteLine(person.Name);
            (int sum, int product) calc(int a, int b) // method using tuple 
            {
                return (a + b, a * b);
            }

            var result = calc(5, 4);
            Console.WriteLine(result.sum);
            Console.WriteLine(result.product);*/

            /*
            //TPL task Parallel Lib similar to runnable interface in java provide run method
            Task t = Task.Run(() => {
                Console.WriteLine("Running the task, task manage thread");
            });
            t.Wait();

            Task<int> t1 = Task.Run(() => {
                return 12;
            });
             int result = t1.Result;
            Console.WriteLine(result);
            t1.Wait();
            Console.WriteLine("Main Thread Done.");*/



            Person person = new Person();

            // Get the Type object
            Type type = typeof(Person);
            Console.WriteLine("Class: " + type.Name);

            // List of properties
            Console.WriteLine("\nProperties:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.Name} -- {prop.PropertyType.Name}");
            }

            // List of constructors
            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                string parameters = string.Join(", ", ctor.GetParameters()
                    .Select(p => $"{p.ParameterType.Name} {p.Name}"));
                Console.WriteLine($"{ctor.Name}({parameters})");
            }

            // Get the private field 'name'
            FieldInfo fieldInfo = type.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                // Read the value of the private field
                string fieldValue = (string)fieldInfo.GetValue(person);
                Console.WriteLine("\nPrivate Field Value: " + fieldValue);

                // Modify the private field
                fieldInfo.SetValue(person, "Hell");

                // Call method to see the updated field
                Console.WriteLine("\nAfter modifying the private field:");
                person.DisplayName();
            }
            else

                Console.WriteLine("Private field 'name' not found.");


            Console.ReadKey();
        }
        static void PrintMessage1(object state)
        {
            string message = (string)state;
            Console.WriteLine(message);
        }

        static void Printno(object n)
        {
            for (int i = 10; i <= 100; i += 10)
            {
                //Thread.Sleep(1000);
                Console.WriteLine(i + " % : Completed ");
                Thread.Sleep(1000);
            }
        }



        static void PrintMessage(object message)
        {
            Console.WriteLine($" Message : {message}");
        }

        public static bool isEqual<T>(T a, T b) where T : class
        {
            //return a.Equals(b); //    return object.Equals(a, b); // use this then remove where T class
            return a == b;
        }

    }
}
