using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal static class RunMyAllProg
    {
        public static void countUnique(int[] arr)
        {
            ArrayPractice.countUnique(arr);
        }

        public static void FindMissingAndDuplicate(int[] arr)
        {
            ArrayPractice.FindMissingAndDuplicate(arr);
        }
        public static void AlreadySorted(int[] arr)
        {
            ArrayPractice.AlreadySorted(arr);
        }
        public static void secondLargest(int[] arr)
        {
            ArrayPractice.secondLargest(arr);
        }
        public static void palindromeNum(int[] arr)
        {
            ArrayPractice.PalindromeNumber(arr);
        }
        public static void maxMin(int[] arr)
        {
            ArrayPractice.maxMin(arr);
        }

        public static void reverseArr(int[] arr)
        {
            ArrayPractice.reverseArr(arr);
        }
        public static void IndexcerCall()
        {
            Indexer obj = new Indexer();
            obj[0] = 1321;
            obj[1] = 23;
            obj[2] = 32;
            obj.show();
        }

        public static  void InheritanceProp()
        {
            Inheritance animal = new Dog();
            animal.talk(); // parent method
            animal = new Lion();
            animal.talk();
            animal = new Cat();
            animal.talk();                                             
        }
    }
}
