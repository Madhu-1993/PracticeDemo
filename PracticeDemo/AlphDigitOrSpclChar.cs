using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to input any character and check whether it is alphabet, digit or special character 
namespace PracticeDemo
{
    internal class AlphDigitOrSpclChar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = char.Parse(Console.ReadLine());

            if(ch>='A' && ch<='Z' || ch>='a' && ch<='z')
            {
                Console.WriteLine("character is Alphabet");
            }
            else if(ch>='0' && ch<=9)
            {
                Console.WriteLine("character is Digit");
            }
            else
            {
                Console.WriteLine("Character is Special character");
            }
        }
    }
}
