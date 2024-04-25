using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class CallByRefDemo
    {   
        //Call By Value
        public void Swap (int a , int b)
        {
            int temp = a;
                a = b;
            b = temp;

        }

        // Call by ref
        public void Swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
}
