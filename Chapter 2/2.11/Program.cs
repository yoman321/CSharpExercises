using System;

namespace _2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of years: ");
            double years = Convert.ToInt32(Console.ReadLine());

            double birth = (60 * 60 * 24 * 365) / 7;
            double death = (60 * 60 * 24 * 365) / 13;
            double immigrant = (60 * 60 * 24 * 365) / 45;

            int population = Convert.ToInt32(312032486.0 + (birth + immigrant - death) * years);

            Console.WriteLine($"The population in {years} years is {population}");

        }
    }
}
