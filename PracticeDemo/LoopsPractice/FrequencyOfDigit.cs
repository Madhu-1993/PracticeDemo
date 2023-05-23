using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Write a program to find frequency of each digit in a given integer.

namespace PracticeDemo.LoopsPractice
{
    internal class FrequencyOfDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            int count = 0, freq = 0;

            for(int i=0;i<10;i++)
            {
                for(int j=num;j>0;j=j/10)
                {
                    freq = j % 10;
                    if(freq==i)
                    {
                        count++;
                    }
                }
            }
        }
    }
}
