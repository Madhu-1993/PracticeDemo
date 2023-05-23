using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	Find all prime number between 400 to 300;

namespace PracticeDemo.LoopsPractice
{
    internal class Prime400To300
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            bool isPrime = true;

            for(int i=300; i<400; i++)
            {
                if(num%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
