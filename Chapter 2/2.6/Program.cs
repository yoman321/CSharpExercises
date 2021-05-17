using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Input a number between 0 and 1000: ");
           int nbre = Convert.ToInt32(Console.ReadLine());
           
           while (nbre >= 1000 || nbre <= 0)
           {
               Console.WriteLine("The integer does not respect boundaries. Please input anothe number: ");
               nbre = Convert.ToInt32(Console.ReadLine());
           }
            int sum = 0;
            sum += nbre % 10 + (nbre /= 10) % 10 + (nbre /= 10) % 10;

            Console.WriteLine($"The sum of its digits is {sum}");
        }
    }
}
