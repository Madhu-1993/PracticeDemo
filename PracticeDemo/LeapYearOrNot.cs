using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to check whether a year is leap year or not 

namespace PracticeDemo
{
    internal class LeapYearOrNot
    {
        public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year");
            year=int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 400 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("Year is leap year");
            }
            else
            {
                Console.WriteLine("year is not leap year");
            }
        }
    }
}
