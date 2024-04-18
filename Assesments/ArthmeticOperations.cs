using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.write a code to overload the static method to calculate the all the arthmetic operations.*/

namespace Assesments
{
    public class ArthmeticOperations
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Division by zero is not allowed");
            return a / b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Division by zero is not allowed");
            return a / b;
        }
    }
}
