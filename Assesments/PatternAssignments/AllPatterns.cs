using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.PatternAssignments
{
    public class AllPatterns
    {
        public void RightTriangleStar(int rows)
        {
            for(int i=1; i<=rows; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void ReverseRightTriangleStar(int rows)
        {
            for(int i=rows; i >= 1; i--)
            {
                for (int j=1; j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
