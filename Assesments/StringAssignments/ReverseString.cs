using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assesments.StringAssignments
{

    public class ReverseString
    {
        //Write a C# program to find reverse of a string.
        public void ReverseGivenString(string str)
        {
            char[] ch = str.ToCharArray();
            string str1 = "";

            for(int i = 0; i < ch.Length; i++)
            {
                str1=ch[i]+str1;
            }

            Console.WriteLine($"Reverse String is : {str1}");
        }


        //Write a C# program to reverse a given string with preserving the position of spaces

        public void ReverseByPreserveSpaces(string str)
        {
            Console.WriteLine($"Original : {str}");
            char[] ch = str.ToCharArray();
            char[] ch1 = new char[ch.Length];

            int a = ch.Length-1;

            for(int i = 0;i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    ch1[i] = ' ' ;
                }
                else
                {   

                    for(; a >= 0; a--)
                    {
                        if (ch1[a]==' ')
                        {
                            continue;
                        }
                        else
                        {
                            ch1[a--] = ch[i];
                            break;
                        }
                    }
                }
            }

            string str1 = new string(ch1);
            Console.WriteLine("Reverse : "+str1);
        }
    }




}
