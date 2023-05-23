using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a C# program to check whether a number is divisible by 5 and 11 or not 

namespace PracticeDemo
{
    internal class DivisibleBy5Or11
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int number=int.Parse(Console.ReadLine());
            if(number % 5==0 && number % 11==0)
            {
                Console.WriteLine("number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("number is not divisible by 5 and 11");
            }
        }
    }
}
