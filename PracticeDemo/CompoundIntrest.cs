using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a  program to enter P, T, R and calculate Compound Interest.
//principle(1+r/100)^n
namespace PracticeDemo
{
    internal class CompoundIntrest
    {
        public static void Main(string[] args)
        {
            int n, p;
            float r;
            Console.WriteLine("Enter the principle,rate,year");
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            r = float.Parse(Console.ReadLine());

            float rate = (float)Math.Pow((1 + r / 100),n);
            double CI = p * r;

        }
    }
}
