using System;
using System.Collections.Generic;

namespace puzzle_net_core
{
    class Program
    {
        public const int val = 2;

        public static int i = 0;

        static void Main(string[] args)
        {
            IIEmployeeService general = new EmployeeService();
            Console.WriteLine("general.getRetirementAge() :" + general.getRetirementAge());

            general = new SteamService();
            Console.WriteLine("steam.getRetirementAge() ;" + general.getRetirementAge());

            /*Console.WriteLine("Hello World!");
            Palindrome palindrome = new Palindrome();
            palindrome.printIsPalindrome("Liril");
            palindrome.printIsPalindrome("LiriL");
            palindrome.printIsPalindrome("Laurel");
            palindrome.printIsPalindrome("123321");
            palindrome.printIsPalindrome("odd1ddo");
            palindrome.printIsPalindrome("eveeve");

            //Inheritence
            Child.ManipulateString("krishsa");*/

            // PartialClass pc = new PartialClass();
            // pc.TestGetOptionDictionary();

            /*   MergeArrays ma = new MergeArrays();
              ma.UniqueNames();
              ma.TestMerageAndRemoveDuplicatesUsingCollections();

              Console.WriteLine(Math.Round(5.4));
              Console.WriteLine(Math.Round(11.5));


              int[] arr = new int[2];
              arr[1] = 10;
              Object o = arr;
              int[] arr1 = (int[])o;
              arr1[1] = 100;
              Console.WriteLine(arr[1]);
              ((int[])o)[1] = 1000;
              Console.WriteLine(arr[1]);

   */
            /*  Program p = new Program();
             p.print(2, 3, 8);

             int[] arr = { 2, 11, 15, 20 };
             p.print(arr);

             int num1 = 20;
             int num2 = 30;
             num1 ^= num2 ^= num1 ^= num2;
             Console.WriteLine(num1 + "," + num2);
  */
            /* int i, j = 1, k;
            for (i = 0; i < 5; i++)
            {
                k = j++ + ++j;
                Console.Write(k + " ");
            } */

            /*  int[] arr = { 1, 2, 3 };
             int i = 1;
             arr[i++] = arr[i] + 10;
             Console.WriteLine(String.Join(",", arr)); 
  */
            double num1 = 1.000001;
            double num2 = 0.000001;
            Console.WriteLine((num1 - num2));
        }

        public void print(params int[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
        }


    }

    
    }
}
