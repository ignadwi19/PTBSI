using System;

namespace SumArgument
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Enter 4 Number");
int[] number = new int[4];
for(int i = 0;i<4;i++)
{
    number[i]= Console.ReadLine();
}

Console.WriteLine("Total = " + number.Sum());
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
        }
    }
}
