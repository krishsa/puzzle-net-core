using System;
class Palindrome
{
    public Boolean isPalindrome(string word)
    {

        var letters = word.ToLower().ToCharArray();
        int count = (letters.Length % 2 == 0) ? (letters.Length / 2) : (letters.Length / 2 + 1);
        for (int i = 0; i < count; i++)
        {
            if (!letters[i].Equals(letters[letters.Length - (i + 1)]))
            {
                return false;
            }
        }
        return true;

    }

    public void printIsPalindrome(string word)
    {
        Console.WriteLine(word + " Is Palindrome :" + this.isPalindrome(word));
    }
}