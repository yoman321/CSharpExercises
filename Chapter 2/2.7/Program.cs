using System;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number of minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int years = minutes / 60 / 24 / 365;
            int days = minutes / 60 / 24 % 365;

            Console.WriteLine($"{minutes} minutes is approx {years} years and {days} days");
        }
    }
}
