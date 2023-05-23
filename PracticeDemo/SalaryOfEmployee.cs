using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to input basic salary of an employee and calculate its 
//Gross salary according to following:
//Basic Salary <= 10000 : HRA = 20%, DA = 80%
//Basic Salary <= 20000 : HRA = 25%, DA = 90%
//Basic Salary >20000 : HRA = 30%, DA = 95% 

namespace PracticeDemo
{
    internal class SalaryOfEmployee
    {
        public static void Main(string[] args)
        {
            int Salary, Gross, Hra, Da;
            Console.WriteLine("Enter the basic salary of the employee");
            Salary=int.Parse(Console.ReadLine());

            if(Salary<=10000)
            {
                Da = Salary * 20 / 100;
                Hra = Salary * 80 / 100;
                Gross = Salary + Da + Hra;

                Console.WriteLine("The gross salary is="+ Gross);
            }
            else if (Salary <= 20000)
            {
                Da = Salary * 25/ 100;
                Hra = Salary * 90 / 100;
                Gross = Salary + Da + Hra;

                Console.WriteLine("The gross salary is=" + Gross);
            }
            else if (Salary >20000)
            {
                Da = Salary * 30 / 100;
                Hra = Salary * 95 / 100;
                Gross = Salary + Da + Hra;

                Console.WriteLine("The gross salary is=" + Gross);
            }
            else
            {
                Console.WriteLine("Employee has no salary");
            }
        }
    }
}












