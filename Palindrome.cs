using System;
class Palindrome
{
    public Boolean isPalindrome(string word)
    {
        var letters = word.ToLower().ToCharArray();
        for (int i = 0; i < letters.Length / 2; i++)
        {

            if (!(letters[i]).Equals(letters[letters.Length - i + 1]))
            {
                return false;
            }
            Console.WriteLine(i + " " + letters.Length);
        }
        return true;
    }
}