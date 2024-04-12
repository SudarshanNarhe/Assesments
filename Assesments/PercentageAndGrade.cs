using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a code to calculate the five subject percentage and as per the percentage display the grade
namespace Assesments
{
    internal class PercentageAndGrade
    {
        public static double calPercentage(int sub1,int sub2,int sub3, int sub4, int sub5)
        {
            double percentage = (sub1 + sub2 + sub3 + sub4 + sub5) / 5;
            return percentage;
        }

        public static void showGrade(double per)
        {   

            if (per > 80)
            {
                Console.WriteLine("Grade : A ");
            }else if (per > 60)
            {
                Console.WriteLine("Grade : B ");
            }else if (per > 50)
            {
                Console.WriteLine("Grade : C ");
            }else if (per > 35)
            {
                Console.WriteLine("Grade : D ");
            }
            else
            {
                Console.WriteLine("Grade : F ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a marks of first subject : ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of second subject : ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of third subject : ");
            int sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of fourth subject : ");
            int sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of fifth subject : ");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            double per = calPercentage(sub1, sub2, sub3, sub4, sub5);
            Console.WriteLine("Percentage is : "+per);
            showGrade(per);
        }
    }
}
