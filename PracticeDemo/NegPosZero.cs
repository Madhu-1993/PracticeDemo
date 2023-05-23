using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a C# program to check whether a number is negative, positive or zero 

namespace PracticeDemo
{
    internal class NegPosZero
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            if(number<0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if(number>0)
            {
                Console.WriteLine("Number is Possitive");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }
    }
}
