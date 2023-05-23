using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to check whether a number is even or odd  

namespace PracticeDemo
{
    internal class EvenOdd
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the numnber");
           int number=int.Parse(Console.ReadLine());

            if(number%2==0 )
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
