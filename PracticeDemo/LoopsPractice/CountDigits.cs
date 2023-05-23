using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	 Write a  program to count number of digits in any number
//532%10=2 ||532/10=53
//53%10=3  || 53/10=5
//5%10=5 || 5/10=0

namespace PracticeDemo.LoopsPractice
{
    internal class CountDigits
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int num;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            for(int i=0; i<num; i++)
            {
                num = num % 10;
                count++;
            }
        }
    }
}
