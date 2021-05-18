using System;

namespace _3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the day of the month (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            if (month == 1)
            {
                month = 13;
                year -= 1;
                
            }
            else if (month == 2)
            {
                month = 14;
                year -= 1;
            }

            int century = year / 100;
            int yearOfCentury = year % 100;

            int dayOfWeek = (day + (26 * (month + 1))/ 10 + yearOfCentury + yearOfCentury / 4 + century / 4 + 5 * century) % 7;
            switch(dayOfWeek)
            {
                case 0: Console.WriteLine($"The day of the week is Saturday"); break;
                case 1: Console.WriteLine($"The day of the week is Sunday"); break;
                case 2: Console.WriteLine($"The day of the week is Monday"); break;
                case 3: Console.WriteLine($"The day of the week is Tuesday"); break;
                case 4: Console.WriteLine($"The day of the week is Wednesday"); break;
                case 5: Console.WriteLine($"The day of the week is Thursday"); break;
                case 6: Console.WriteLine($"The day of the week is Friday"); break;
            }

        }
    }
}
