using System.Reflection.Metadata.Ecma335;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 

            double celsius = TempConverter.FahrenheitToCelsius(68);

            Console.WriteLine($"In celsius, the temperature provided is :{celsius}");

                  double fahrenheit = TempConverter.CelsiusToFahrenheit(20);

                    Console.WriteLine($"In fahrenheit, the temperature provided is: {fahrenheit}");




        }
    }
}
