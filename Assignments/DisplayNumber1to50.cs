using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a code to display number between 1 to 50 at the time of display if number is divisible by 3 then display 'Pune' 
//if number is divisible by 5 then display 'Welcome' and if 3 and 5 display 'Welcome to Pune'

namespace Assesments
{
    internal class DisplayNumber1to50
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 50; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to Pune");
                }else if (i % 3 == 0)
                {
                    Console.WriteLine("Pune");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
