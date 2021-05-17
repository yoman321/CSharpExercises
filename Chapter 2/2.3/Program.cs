using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for feet: ");
            double feets = Convert.ToDouble(Console.ReadLine());

            double meters = feets * 0.305;

            Console.WriteLine($"{feets} feet is {meters} meters.");
        }
    }
}
