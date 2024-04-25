using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class GenericMethodDemo
    {
        public void Swap<T>(T a, T b)
        {
            Console.WriteLine(a + "   " + b);

            T temp = a;
            a= b;
            b= temp;

            Console.WriteLine(a+"   "+b);
        }

    }
}
