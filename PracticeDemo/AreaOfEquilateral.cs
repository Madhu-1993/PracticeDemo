using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate area of an equilateral triangle.

namespace PracticeDemo
{
    internal class AreaOfEquilateral
    {
      public static void Main(string[] args)
      {
            int side;
            Console.WriteLine("Enter the side");
            side=Convert.ToInt32(Console.ReadLine());
            float root =  (float)Math.Sqrt(3) / 4;
            double area = root * (side * side);

            Console.WriteLine("Area of equilateral traingle is"+ area);
      }

    }
}
