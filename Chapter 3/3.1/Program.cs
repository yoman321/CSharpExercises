using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a, b, c: ");
            String[] values = Console.ReadLine().Split();
            double a = Convert.ToDouble(values[0]);
            double b = Convert.ToDouble(values[1]);
            double c= Convert.ToDouble(values[2]);
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant > 0)
            {
                double r1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                double r2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("The equation has two roots {0:0.00} and {1:0.00}", r1, r2);
            }
            else if (discriminant == 0)
            {
                double r1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("The equation has one root {0:0.00}", r1);

            }
            else 
            {
                Console.WriteLine("The equation has no roots");
            }
        }
    }
}
