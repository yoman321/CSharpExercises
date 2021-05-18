using System;

namespace _3._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a point with two coordinates: ");
            String[] values = Console.ReadLine().Split();
            double x = Convert.ToDouble(values[0]);
            double y = Convert.ToDouble(values[1]);

            if (Math.Abs(x) <= 10.0 / 2 && Math.Abs(y) <= 5.0 / 2)
            {
                Console.WriteLine($"The point ({x}, {y}) is in the rectangle");
            }
            else
            {
                Console.WriteLine($"The point ({x}, {y}) is not in the rectangle");
            }
        }
    }
}
