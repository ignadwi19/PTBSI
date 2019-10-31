using System;

namespace DaysToNextBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime birthday = DateTime.Parse("03/19/2020"); 
            birthday.ToString();
			today.ToString();
            // Count the days of your next birthday
            string nextBirth = birthday - today;
            Console.WriteLine($"{nextBirth} days remaining to my next birthday.");
        }
    }
}
