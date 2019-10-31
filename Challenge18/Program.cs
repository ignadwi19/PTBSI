using System;

namespace FindMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            FindMax(numbers); // Output: 330
            FindMin(numbers); // Output: -65
            FindAverage(numbers); // Output: 52.16
        }

        static int FindMax(int[] numbers)
        {
            int max = numbers.Max();
            return 0;
        }

        static int FindMin(int[] numbers)
        {
             int min = numbers.Min();
            return 0;
        }

        static int FindAverage(int[] numbers)
        {
            double avg = Queryable.Average(numbers.AsQueryable());  
            return 0;
        }
    }
}
