using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//	 Write a  program to calculate product of digits of any number.

namespace PracticeDemo.LoopsPractice
{
    internal class ProdOfDigits
    {
        public static void Main(string[]args)
        {
            int count=0;
            int prod = 1;
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            
            for(int i=0; i<num; i++)
            {
                num = num % 10;
                 prod = prod * num;
                count++;
            }
        }
    }
}
