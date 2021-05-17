using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the subtotal and a gratuity rate: ");
            String[] values = Console.ReadLine().Split(" ");

            double gratuity = Convert.ToDouble(values[1]) * 0.01 * Convert.ToDouble(values[0]);
            double total = Convert.ToDouble(values[0]) + gratuity;

            Console.WriteLine($"The gratuity is ${gratuity} and total is ${total}.");
        }
    }
}
