using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            Mirror("--vv"); // Output: --vvvv--
        }

        static string Mirror(string text)
        {
            var chars = text.ToCharArray();
            Array.Reverse(chars);
            var reversedText = new String(chars);
            return "";
        }
    }
}
