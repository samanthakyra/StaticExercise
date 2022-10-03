using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); 

            Console.WriteLine("After using the conversion");
            Console.WriteLine($"The celcius is {celsius}");
            Console.WriteLine($"The fahrenheit is {fahrenheit}");
        }
    }
}