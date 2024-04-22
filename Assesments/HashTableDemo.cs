
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(91, "IND");
            ht.Add(1, "USA");
            ht.Add(63, "AUS");

            //  ht.Remove(63); // remove is based on key

            Console.WriteLine("------Hashtable-----------");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


            SortedList list = new SortedList();

            list.Add(104, "HR");
            list.Add(103, "Sales");
            list.Add(101, "Development");
            list.Add(102, "Testing");

            // list.Remove(104);
            Console.WriteLine("------SortedList-----------");
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
