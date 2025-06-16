using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    
    internal class Student
    {
        public static int count;
        public static int count1;
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {
            count++;
        }

        // write a prog to get count of prime no from 1 to 100
        public void primeNumberCount()
        {
          
            for (int num = 2; num <= 100; num++)
            {
                bool isTrue = true;

                for (int i = 2; i <= num /2; i++) // or i=2 i*i<= num i++
                {
                    if (num % i == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }

                if (isTrue)
                    count1++;
          
            }

            Console.WriteLine("the Count is : "+count1);
        }


        public void setStudent(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;

        }

        public void getStudent()
        {
            Console.WriteLine($"Id is :{Id}, name is :{Name}");
        }

        public int retunCount()
        {
            return count;
        }


    }
    
    }
