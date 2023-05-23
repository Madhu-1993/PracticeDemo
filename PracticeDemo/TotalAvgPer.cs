using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to enter marks of five subjects and calculate total, average and percentage
namespace PracticeDemo
{
    internal class TotalAvgPer
    {
        public static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5;
            int total;
            float avg, per;
            Console.WriteLine("Enter the marks of 5 subject");
            sub1 = int.Parse(Console.ReadLine());
            sub2=int.Parse(Console.ReadLine());
            sub3=int.Parse(Console.ReadLine());
            sub4=int.Parse(Console.ReadLine());
            sub5= int.Parse(Console.ReadLine());

            total=sub1+sub2+sub3 +sub4+sub5;

            avg = total / 5; 
            
            per=avg/5;

            Console.WriteLine("Total="+" "+total+"Average="+" "+"Percentage=");
        }
    }
}
