using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
⦁    WAP to print even numbers from 121 to 229 using for loop. 
⦁	 WAP to print odd numbers from 521 to 229 using while loop. 
⦁	 WAP to print even numbers from 121 to 229 using do-while loop.
*/

namespace Assesments.BasicAssignments
{
    internal class LoopPractice
    {
        public static void forloopDemo()
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void whileloopDemo()
        {
            int i = 121;
            while (i <= 229)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public static void dowhileloopDemo()
        {
            int i = 121;
            do
            {
                if (i % 2 == 0)
                { Console.WriteLine(i); }
            } while (i <= 229);
        }

        static void Main(string[] args)
        {
            forloopDemo();
            Console.WriteLine();
            whileloopDemo();
            Console.WriteLine();
            dowhileloopDemo();
        }
    }
}
