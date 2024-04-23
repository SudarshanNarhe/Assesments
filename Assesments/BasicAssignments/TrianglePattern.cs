using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class TrianglePattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to draw till the pattern : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=number; i++)
            {
                for(int j=number; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
