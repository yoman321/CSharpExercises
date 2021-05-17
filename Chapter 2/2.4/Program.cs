using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kilo = pounds * 0.454;
            Console.WriteLine($"{pounds} pounds is {kilo} kilosgrams.");
        }
    }
}
