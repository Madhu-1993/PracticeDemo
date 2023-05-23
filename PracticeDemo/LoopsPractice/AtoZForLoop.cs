using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Write a program to print all alphabets from a to z. - using  for loop

namespace PracticeDemo.LoopsPractice
{
    internal class AtoZForLoop
    {
        public static void Main(string[] args)
        {
            char ch;
            for(ch='A';ch<='Z';ch++)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
