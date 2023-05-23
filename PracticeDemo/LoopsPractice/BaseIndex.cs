using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	WAP to accept base and index from user and calculates power

namespace PracticeDemo.LoopsPractice
{
    internal class BaseIndex
    {
        public static void Main(string[] args)
        {
            int baseNum, power=1, exponent;
            Console.WriteLine("Enter the num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter base, power");
            baseNum=int.Parse(Console.ReadLine());
            exponent=int.Parse(Console.ReadLine());

            power= power * baseNum;

            Console.WriteLine();

        }

    }
}
