using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How do you swap two string variables without using third or temp variable in C#

namespace Assesments.StringAssignments
{
    public class SwapString
    {
        public void SwapStringWithoutUsingTemp(string str1, string str2)
        {
            Console.WriteLine($"Before swap str1 : {str1} , str2 : {str2}");

            str1 = str1 + str2;

            str2 = str1.Substring(0, str1.Length - str2.Length);

            str1 = str1.Substring(str2.Length);

            Console.WriteLine($"After swap str1 : {str1} , str2 : {str2}");

        }
    }
}
