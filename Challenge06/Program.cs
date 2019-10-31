using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
     Console.WriteLine("Enter Your Name");
     int Input = Console.ReadLine();
     Console.WriteLine("{0}", Grade(Input));
			
string Grade(int number) {
	String value;
if (number > 90) {
     value = "A";
}
else if((number > 79) && (number < 90)) {
    value = "B";
}
else if((number > 69) && (number < 80)) {
    value = "C";
}
else if((number > 59) && (number < 70)) {
    value = "D";
}
else if(number < 60) {
    value = "E";
}
	return value;
            }
       
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
        }
    }
}
