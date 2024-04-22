using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Java program print total number of days in a month 

namespace Assesments
{
    internal class DaysOfMonth
    {
        public static void daysOfMonth(int month)
        {
            if (month % 2 != 0)
            {
                Console.WriteLine("31 days");
            }
            else if(month ==2)
            {
                Console.WriteLine("Enter a year : ");
                int year = Convert.ToInt32(Console.ReadLine());
                if(year%4 == 0)
                {
                    Console.WriteLine("29 days");
                }
                else
                {
                    Console.WriteLine("28 days");
                }
            }
            else
            {
                Console.WriteLine("30 days");
            }
        }
        static void Main(string[] args)
        {   

            Console.WriteLine("Enter a proper choice ---->>\n1.January\n2.February\n3.March\n4.April\n5.May\n6.June" +
                "\n7.July\n8.August\n9.September\n10.October\n11.November\n12.December");
            int choice = Convert.ToInt32(Console.ReadLine());
            daysOfMonth(choice);
        }
    }
}
