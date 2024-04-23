using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class ArrayListDemo
    {
       static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(12);
            arr.Add(28.67);
            arr.Add("Sudarshan");
            arr.Add('c');
            arr.Add(true);
           // arr.Add(new Products(12, "Laptop", 78000));

            arr.Insert(1, 34.56);
            //  arr.AddRange(arr);

            arr.Remove(34.56);
            //  arr.RemoveAt(1);

            // arr.RemoveRange(1, 3);

            // arr.Clear();

            // arr.Sort();

            //arr.Reverse();

            Console.WriteLine($"Total Elements from the list ={arr.Count}");

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
