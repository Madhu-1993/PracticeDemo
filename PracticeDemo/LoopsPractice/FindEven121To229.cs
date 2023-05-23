using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//	WAP to print even numbers from 121 to 229 using do-while loop. 

namespace PracticeDemo.LoopsPractice
{
    internal class FindEven121To229
    {
        public static void Main(String[] args)
        {
            int i;
            do
            {
                for(i=121; i<=229;i++)
                {
                    Console.WriteLine("Even number="+i);
                }

            }
            while (i % 2 == 0);
        }
    }
}
