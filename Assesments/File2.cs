using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public partial class Calc
    {
        public void Sub(int num1, int num2)
        {
            int res = num1 - num2;
            Print(res);
        }

        partial void Print(int a)
        {
            Console.WriteLine($"Result is : {a}");
        }
    }

    public partial class Calc
    {
        public void Multi(int num1, int num2)
        {
            int res = num1 * num2;
            Print(res);
        }
    }
}
