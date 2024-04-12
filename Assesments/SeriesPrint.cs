using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class SeriesPrint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which you have to Print : ");

            int num = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            Console.WriteLine("The Series is : ");
            for(int i=1; i<=10; i++)
            {
                result = num * i;
                Console.WriteLine(result);
            }
        }
    }
}
