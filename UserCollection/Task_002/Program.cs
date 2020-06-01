using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = new MonthCollection();

            Console.WriteLine(months.DaysByMonths(30));

            Console.WriteLine(months.NumByMonths(5));
            
        }
    }
}