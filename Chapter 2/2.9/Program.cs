using System;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter v0, v1, and t: ");
            String[] values = Console.ReadLine().Split(" ");

            double acceleration = ((Convert.ToDouble(values[1])) - Convert.ToDouble(values[0])) / Convert.ToDouble(values[2]);

            Console.WriteLine($"The avaerage acceleration is {acceleration}");
        }
    }
}
