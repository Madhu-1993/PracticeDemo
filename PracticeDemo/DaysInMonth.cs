using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program print total number of days in a month 

namespace PracticeDemo
{
    internal class DaysInMonth
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter month number");
            int MonthNum = int.Parse(Console.ReadLine());

            if (MonthNum == 1 || MonthNum == 3 || MonthNum == 5 || MonthNum == 7
                || MonthNum == 8 || MonthNum == 10 || MonthNum == 12)
            {
                Console.WriteLine("31");
            }
            else if (MonthNum == 4 || MonthNum == 6 || MonthNum == 9 || MonthNum == 11)
            {
                Console.WriteLine("30");
            }
            else if (MonthNum == 2)
            {
                Console.WriteLine("28");
            }
        }
    }
}
