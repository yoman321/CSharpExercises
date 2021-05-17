using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the degree in Celsius: ");
            String stringDegree = Console.ReadLine();

            double fahrenheit = ((double)9 / (double)5) * Convert.ToDouble(stringDegree) + 32;

            Console.WriteLine($"The celcius converted to fahrenheit is {fahrenheit}.");
        }
    }
}
