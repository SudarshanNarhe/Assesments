using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to find total number of alphabets, digits or special character in a string.

namespace Assesments.StringAssignments
{
    public class FindNumbersAndDigits
    {
        public void FindTotalNumbersDigitsAndAplabhets(string str)
        {
            Console.WriteLine(str);
            char[] ch = str.ToCharArray();

            int dcount = 0;
            int acount = 0;
            int scount = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != ' ')
                {

                    if (ch[i] >= '0' && ch[i] <= '9')
                    {
                        dcount++;
                    }
                    else if ((ch[i] >= 'A' && ch[i] <= 'Z') || (ch[i] >= 'a' && ch[i] <= 'z'))
                    {
                        acount++;
                    }
                    else
                    {
                        scount++;
                    }
                }
            }

            Console.WriteLine($"The digit count is : {dcount}\nThe Alphabtes count is : {acount}\nThe Special Character count is : {scount}");
        }

    }
}
