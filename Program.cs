using System;

namespace puzzle_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palindrome palindrome = new Palindrome();
            palindrome.printIsPalindrome("Liril");
            palindrome.printIsPalindrome("LiriL");
            palindrome.printIsPalindrome("Laurel");
            palindrome.printIsPalindrome("123321");
            palindrome.printIsPalindrome("odd1ddo");
            palindrome.printIsPalindrome("eveeve");
        }
    }
}
