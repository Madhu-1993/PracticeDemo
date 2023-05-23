using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////⦁	.WAP to print table of given no

namespace PracticeDemo.LoopsPractice
{
    internal class PrintTable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                num = num * i;
                Console.WriteLine("2"+"*"+" "+i+" = "+num);
            }
        }
    }
}
