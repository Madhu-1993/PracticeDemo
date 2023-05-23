using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to find maximum between three numbers 

namespace PracticeDemo
{
    internal class MxBetwn3No
    {
        public static void Main(string[]args)
        {
            int a, b, c;
            Console.WriteLine("Enter numbers");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("a is greter");
            }
            else if(b>a && b>c) 
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greter");
            }
        }
    }
}
