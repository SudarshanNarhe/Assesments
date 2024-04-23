using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.ArrayAssignments
{
    public class PrintArray<T>
    {
        public static void Print(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+", ");
            }
            Console.WriteLine();
        }
    }
}
