using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double feelsDifferent = 60;

            Console.WriteLine($"Converting {feelsDifferent} degrees celcius to fahrenheit gives you " + TempConverter.CelsiusToFahrenheit(feelsDifferent));
                     
            Console.WriteLine($"Converting {feelsDifferent} degrees fahrenheit to Celcius, however, gives you " + TempConverter.FahrenheitToCelcius(feelsDifferent));
        }
    }
}
