using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	Print Series 2 -4 6 -8………n terms

namespace Assesments
{
    internal class PrintSeries
    {
        public static void printSeries(int num)
        {   
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if(i%2 == 0)
                {
                    count++;
                    if(count%2 == 0)
                    {
                        int num1 = -i;
                        Console.Write(num1+" ");
                    }
                    else
                    {
                        Console.Write(i+" ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number till where you want : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            printSeries(terms);
        }
    }


}

