using System;

namespace _3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a point with two coordinates: ");
            String[] values = Console.ReadLine().Split();
            double x1 = Convert.ToDouble(values[0]);
            double y1 = Convert.ToDouble(values[1]);

            double distance = Math.Sqrt(Math.Pow(x1 - 0, 2) + Math.Pow(y1 - 0, 2));
            if (distance <= 10)
            {
                Console.WriteLine($"The point ({x1}, {y1}) is in the circle");
            }
            else
            {
                Console.WriteLine($"The point ({x1}, {y1}) is not in the circle");
            }
        }
    }
}
