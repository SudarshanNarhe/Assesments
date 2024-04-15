using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


//Write a program to check whether a year is leap year or not 
namespace Assesments
{
    internal class LeapYear
    {
        public void checkLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                Console.WriteLine(year+" is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is NOT Leap Year");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYear lp = new LeapYear();
                lp.checkLeapYear(year);
        }
    }
}
