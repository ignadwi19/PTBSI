using System;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] points = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
             for (int i = 0; i <= points.Length; i++)
        {
            if (points[i] > points[i + 1])
            {
                int temp = points[i + 1];
                points[i] = points[i + 1];
                points[i] = temp;
            }

            Console.Write(points[i]);
            }
        }
    }
}
