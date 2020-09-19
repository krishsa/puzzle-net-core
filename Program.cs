using System;

namespace puzzle_net_core
{
    class Program
    {
        public const int val = 2;
        static void Main(string[] args)
        {
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

            MergeArrays ma = new MergeArrays();
            ma.UniqueNames();
            ma.TestMerageAndRemoveDuplicatesUsingCollections();


        }
    }
}
