using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class StringBuilderDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------StringBuilder class");

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb);
            Console.WriteLine($"address of sb {sb.GetHashCode()}");

            Console.WriteLine("-----after changed the value");
            sb.Append("Hello to all");
            Console.WriteLine(sb);
            Console.WriteLine($"address of sb {sb.GetHashCode()}");


            sb.Clear();
            //sb.Length; // to get total characters . i.e. length of string


            StringBuilder sb1 = new StringBuilder("Hello, World!");

            // Displaying the current content of StringBuilder
            Console.WriteLine("Original StringBuilder: " + sb1);

            // Remove method
            sb1.Remove(7, 6); // Removes "World!"
            Console.WriteLine("StringBuilder after Remove(): " + sb1);

            // Replace method
            sb1.Replace("Hello", "Hi"); // Replaces "Hello" with "Hi"
            Console.WriteLine("StringBuilder after Replace(): " + sb1);

            // Clear method
            sb1.Clear(); // Clears the StringBuilder
            Console.WriteLine("StringBuilder after Clear(): " + sb1);

            // Capacity property
            Console.WriteLine("Capacity of StringBuilder: " + sb1.Capacity);

            // Length property
            Console.WriteLine("Length of StringBuilder: " + sb1.Length);
        }
    }
}
