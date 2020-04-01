using System;

namespace Class_04_Task_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine();
            Console.WriteLine("The date 3 days from now is " + today.AddDays(3));
            Console.WriteLine();
            Console.WriteLine("The date 1 month from now is " + today.AddMonths(1));
            Console.WriteLine();
            Console.WriteLine("The date that is one month and 3 days from now is " + today.AddMonths(1).AddDays(3));
            Console.WriteLine();
            Console.WriteLine("The date 1 year and 2 months from now is " + today.AddYears(1).AddMonths(2));
            Console.WriteLine();
            Console.WriteLine("Current month of today is " + today.ToString("MMMM"));
            Console.WriteLine();
            Console.WriteLine("Current year of today is " + today.Year);
            Console.ReadLine();
        }
    }
}
