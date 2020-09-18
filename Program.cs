using System;

namespace puzzle_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palindrome palindrome = new Palindrome();
            var p = palindrome.isPalindrome("Liril");
            Console.WriteLine("Is Palindrome :" + p);
        }
    }
}
