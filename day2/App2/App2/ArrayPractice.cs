using System;
using System.Collections.Generic;
using System.Linq;

namespace App2
{
    internal class ArrayPractice
    {
        public static void PalindromeNumber(int[] p)
        {
            bool isPalin = true;
            for (int i = 0; i < p.Length / 2; i++)
            {
                if (p[i] != p[p.Length - 1 - i])
                {
                    isPalin = false;
                    break;
                }
            }
            if (isPalin)
                Console.WriteLine("Array is palindrome");
            else
                Console.WriteLine("Array is not palindrome");
        }
        public static bool palin(int a) // check a aperticular array element is palindrome or not
        {
            int original = a;
            int reverse = 0;
            while (a > 0)
            {
                int digit = a % 10;
                reverse = reverse * 10 + digit;
                a = a / 10;
            }
            return original == reverse;
        }
        public static void palindrome()
        {
            int[] onum = { 1, 2, 1 };
            int[] num = new int[onum.Length];
            Array.Copy(onum, num, num.Length);
            Array.Reverse(num);
            int flag = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != onum[i])
                {
                    Console.WriteLine("Number Is Not Palindrome");
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine("Number Is Palindrome");


        }


       

        public static void maxMin(int[] a)
        {
            int max = a[0], min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) { max = a[i]; }
                if (a[i] < min) { min = a[i]; }
            }
            Console.WriteLine(max + "  " + min);
        }

        public static void reverseArr(int[] a)
        {
            Array.Reverse(a);
            foreach (int i in a)
                Console.WriteLine(i);
        }

        public static void countUnique(int[] a)
        {
            int count = 0;
            foreach (int n in a)
            {
                if (a.Contains(n))
                    a[n]++;
                else
                    a[n] = 1;
            }
            foreach (var item in a)
            {
                if (item == 1)
                    count++;
            }
            Console.WriteLine("unique values is : " + count);
        }

        public static void AlreadySorted(int[] a)
        {
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[i++])
                {
                    flag = true;
                }
            }
            if (flag)
                Console.WriteLine("Sorted");
        }

        // remove duplicated 


        public static void secondLargest(int[] a)
        {
            if (a == null || a.Length < 2)
            {
                Console.WriteLine("Array should have at least two elements.");
                return;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    secondMax = max;
                    max = a[i];
                }
                else if (a[i] > secondMax && a[i] < max)

                    secondMax = a[i];

            }

            if (secondMax == int.MinValue)

                Console.WriteLine("No second largest element");

            else

                Console.WriteLine("Second largest element is: " + secondMax);

        }




        // you have array n natural no, 1 is missing and 1 is duplicated find out duplicated and missing number in unsorted array
        // see all approch for this program
        public static void FindMissingAndDuplicate(int[] nums)
        {
            int n = nums.Length;
            long sum = 0, sumSq = 0;
            long expectedSum = (long)n * (n + 1) / 2;
            long expectedSumSq = (long)n * (n + 1) * (2 * n + 1) / 6;

            foreach (int num in nums)
            {
                sum += num;
                sumSq += (long)num * num;
            }

            long diff = sum - expectedSum; // duplicate - missing
            long diffSq = sumSq - expectedSumSq; // duplicate^2 - missing^2

            // Solving the system of equations:
            // x - y = diff
            // x^2 - y^2 = diffSq => (x + y)(x - y) = diffSq
            // => (x + y) * diff = diffSq
            long sumXY = diffSq / diff;

            int duplicate = (int)((diff + sumXY) / 2);
            int missing = (int)(sumXY - duplicate);

            Console.WriteLine("Duplicate: " + duplicate);
            Console.WriteLine("Missing: " + missing);
        }

        public static  bool Armstrong(int n)
        {
            double sum =0 ;
            int temp = n ,len = n.ToString().Length;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += Math.Pow(digit,len);
                temp /= 10;   
            }

            return sum == n ;
        }


        public static void PrimeNo(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Not prime");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("Prime: " + n);
            else
                Console.WriteLine("Not prime: " + n);
        }

        public static bool PrimeNoBool(int n) {
            if (n <= 1) {  return false; }
            for (int i = 2; i <= n/2; i++)
            {
                if(n % i ==0)
               return false;
            }
            return true;
        }

        public static int factorial(int n) {
            if (n == 0) { return 1; }
                return n* factorial(n-1);
        }


        public static void Fibo(int n) {
            int a = 0, b = 1;
            Console.Write(a + " " + b+ " ");
            int temp = a + b;
            Console.Write(temp+" ");
            a = b;
            b = temp;
        }
    }
}
