using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
//defree celecius=far-32*5/9
namespace PracticeDemo
{
    internal class Tempareture2
    {
        public static void Main(string[] args)
        {
            float Fahrenheit = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fahrenheit");
            float Celcius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celcius="+ Celcius);
        }
    }
}
