using System;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to convert temprature unit
            CelciusToFahrenheit(0); // Output: 32
            FahrenheitToCelcius(50); // Output: 10
            CelciusToKelvin(100); // Output: 373.15
            KelvinToCelcius(375); // Output: 101.85
            KelvinToFahrenheit(375); // Output: 215.33
            FahrenheitToKelvin(12); // Output: 262.039
        }

        private static double CelciusToFahrenheit(double value)
        {
            double fahrenheit = value*(9/5) + 32;
            return fahrenheit;
        }

        private static double FahrenheitToCelcius(double value)
        {
            double Celcius = (value-32)*(5/9)
            return Celcius;
        }

        private static double CelciusToKelvin(double value)
        {
            double Kelvin = value+273.15;
            return Kelvin;
        }

        private static double KelvinToCelcius(double value)
        {
            double Celcius = value-273.15;
            return Celcius;
        }

        private static double KelvinToFahrenheit(double value)
        {
           fahrenheit = (value - 273.15)*(9/5)+32;
           return fahrenheit;
        }

        private static double FahrenheitToKelvin(double value)
        {
            Kelvin = (value − 32) * (5/9) + 273.15;
            return Kelvin;
        }
    }
}
