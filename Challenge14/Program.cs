using System;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            IsPalindrome("ipsum"); // false
            IsPalindrome("malam"); // true
            IsPalindrome("tidur"); // false
            IsPalindrome("kasur rusak"); // true
            IsPalindrome("ibu ratna antar ubi"); // true
        }

        static bool IsPalindrome(string text)
        {
           int i = 0;
            int j = text.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = text[i];
                char b = text[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
    }
}
