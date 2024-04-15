using Assesments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a Java program to input basic salary of an employee and calculate its 

//Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %

namespace Assesments
{
    internal class CalculateSalaryOfEmployee
    {
        public double calculateGrossSalary(double salary)
        {
            double gross,hra,da;
           
            if(salary <= 10000)
            {
                hra = salary * 20 / 100;
                da = salary * 80 / 100;
                gross = salary + hra + da;
            }
            else if(salary <= 20000)
            {
                hra = salary * 25 / 100;
                da = salary * 90 / 100;
                gross = salary+ hra + da;
            }
            else
            {
                hra = salary * 30 / 100;
                da = salary * 95 / 100;
                gross = salary+ hra + da;
            }
            return gross;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Basic Salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            CalculateSalaryOfEmployee cal = new CalculateSalaryOfEmployee();
            double gross=cal.calculateGrossSalary(salary);
            Console.WriteLine("Your Gross Salary is : "+gross);
        }
    }
}
