using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to find sum of all odd numbers between 1 to n.

namespace PracticeDemo.LoopsPractice
{
    internal class Odd1TOn
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("ente the number");
            int n = int.Parse(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
