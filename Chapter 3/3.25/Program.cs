using System;

namespace _3._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1, y1, x2, y2, x3, y3, x4, y4: ");
            String[] values = Console.ReadLine().Split();

            double x1 = Convert.ToDouble(values[0]);
            double y1 = Convert.ToDouble(values[1]);
            double x2 = Convert.ToDouble(values[2]);
            double y2 = Convert.ToDouble(values[3]);
            double x3 = Convert.ToDouble(values[4]);
            double y3 = Convert.ToDouble(values[5]);
            double x4 = Convert.ToDouble(values[6]);
            double y4 = Convert.ToDouble(values[7]);

            double e = (y1 - y2) * x1 - (x1 - x2) * y1;
            double f = (y3 - y4) * x3 - (x3 - x4) * y3;
            double a = y1 - y2;
            double b = x1 - x2;
            double c = y3 - y4;
            double d = x3 - x4;

            if (a * d - b * c == 0)
            {
                Console.WriteLine("The two lines are parallel");
            }
            else
            {
                double x = (e * d - b * f) / (a * d - b * c);
                double y = (a * f - e *c) / (a * d - b * c);
                Console.WriteLine($"The intersecting point is at ({x}, {y})");
            }
        }
    }
}
