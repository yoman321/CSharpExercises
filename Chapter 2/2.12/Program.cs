using System;

namespace _2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speeed and acceleration: ");
            String[] values = Console.ReadLine().Split();

            double length = Math.Pow(Convert.ToDouble(values[0]), 2) / (2 * Convert.ToDouble(values[1]));
            Console.WriteLine("The minimum runway length for this ariplane is {0:0.00}", length);
        }
    }
}
