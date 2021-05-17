using System;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of water in kilograms: ");
            double amountOfWater = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the initial temperature: ");
            double iTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the final temperature: ");
            double fTemp = Convert.ToDouble(Console.ReadLine());

            double energy = amountOfWater * (fTemp - iTemp) * 4184;

            Console.WriteLine($"The energy needed is {energy}");
        }
    }
}
