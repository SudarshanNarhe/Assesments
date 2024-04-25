using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class ParamsDemo
    {
        public void Display(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length);
        }
    }
}
