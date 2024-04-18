using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{   
    // for partial class the file names should be diff but class name is same
    public partial class Calc
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        partial void Print(int a);
    }
}
