using System;
using System.Globalization;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the offset to current time: ");
            int offset  = 0;

            String stringOffset = Console.ReadLine();

            if (int.TryParse(stringOffset, out offset))
            {
                DateTime currentTime = DateTime.Now;
                DateTime offsetTime = new DateTime();
                
                if (currentTime.Hour + offset >= 24)
                {
                    offsetTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day + 1, currentTime.Hour + offset - 24, currentTime.Minute, currentTime.Second);
                }
                else if (currentTime.Hour + offset <= 0)
                {
                    offsetTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day - 1, currentTime.Hour + offset + 24, currentTime.Minute, currentTime.Second);
 
                }
                Console.WriteLine($"The time with offset is {offsetTime}");
            }
        }
    }
}
