using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to input any alphabet and check whether it is vowel or consonant 

namespace PracticeDemo
{
    internal class VowelConsonent
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the Chracter");
            int  ch =char.Parse(Console.ReadLine());
            
            if(ch=='a' || ch=='i' || ch=='e' || ch=='o' || ch=='u' || ch=='A' || ch=='E' || ch=='O' || ch=='I' || ch=='U')
            {
                Console.WriteLine("Character is vowel");
            }
            else
            {
                Console.WriteLine("Character is Consonent");
            }
        }
    }
}
