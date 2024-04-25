using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    //declare delegate 
    public delegate int MyDelegate(int num1, int num2);
    public class Calci
    {
        
        public int Add(int a, int b)
        {
            return a+ b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

    }
}
