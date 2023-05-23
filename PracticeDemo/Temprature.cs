using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
//degree farade=degree celcius*(9/5)+32
namespace PracticeDemo
{
    internal class Temprature
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the celcius");
            float Celcius=float.Parse(Console.ReadLine());

            float Fahrenheit = Celcius * (9 / 5) + 5;
            Console.WriteLine("Fahrenheit=" + Fahrenheit);
        }
    }
}
