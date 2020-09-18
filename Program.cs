using System;

namespace puzzle_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palindrome palindrome = new Palindrome();
            string input = "Liril";
            var p = palindrome.isPalindrome(input);
            Console.WriteLine(input + " Is Palindrome :" + p);

            input = "Senthis";
            p = palindrome.isPalindrome(input);
            Console.WriteLine(input + " Is Palindrome :" + p);

            input = "liril";
            p = palindrome.isPalindrome(input);
            Console.WriteLine(input + " Is Palindrome :" + p);

            input = "123321";
            p = palindrome.isPalindrome(input);
            Console.WriteLine(input + " Is Palindrome :" + p);


        }
    }
}
