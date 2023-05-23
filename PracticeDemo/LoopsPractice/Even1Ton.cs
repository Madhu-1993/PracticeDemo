using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	 Write a  program to find sum of all even numbers between 1 to n. 

namespace PracticeDemo.LoopsPractice
{
    internal class Even1Ton
    {
        public static void Main(string[]args)
        {
            int i;
            Console.WriteLine("Ente the number");
            int n=int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
