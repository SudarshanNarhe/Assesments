using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class OutDemo
    {
        public string Calculation(int a, int b,out int sum,out int sub,out int mul,out double div)
        {
            sum = a+ b;
            sub = a - b;
            mul = a * b;
            div = a / b;

            return "Done Opeations";
        }
    }
}
