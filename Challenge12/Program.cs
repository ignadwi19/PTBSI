using System;

namespace ToUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Word");
            string Input = Console.ReadLine();
            Input.ToUpper();
            Console.WriteLine(Input);
            // Create a progam that be able to
            // transform all string into uppercase.
        }
    }
}
