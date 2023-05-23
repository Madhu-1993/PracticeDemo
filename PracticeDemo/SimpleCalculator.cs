using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to create Simple Calculator  

namespace PracticeDemo
{
    internal class SimpleCalculator
    {
        public static void Main(string[]args)
        {
            int ch, a, b, c;
            Console.WriteLine("1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division ");
            Console.WriteLine("Enter choice");
            ch=int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the values");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Additon =" +" "+c);      
                break;

                case 2:
                    Console.WriteLine("Enter the values");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Substraction =" + " " + c);
                    break;

                case 3:
                    Console.WriteLine("Enter the values");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Multiplication =" + " " + c);
                    break;

                case 4:
                    Console.WriteLine("Enter the values");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Division =" + " " + c);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
