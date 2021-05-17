using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius and length of a cylinder: ");
            String[] values = Console.ReadLine().Split( );

            double radius = Convert.ToDouble(values[0]);
            double length = Convert.ToDouble(values[1]);

            double area = Math.Pow(radius, 2) * Math.PI;
            double volume = area * length;

            Console.WriteLine($"The area is {area}.");
            Console.WriteLine($"The volume is {volume}");
            
        }
    }
}
