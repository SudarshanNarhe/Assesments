using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class GenericCollectionsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Demo -------->> ");
            
            List<int> ilist = new List<int>();
            ilist.Add(1);
            ilist.Add(2);

            foreach(int i in ilist) 
            {
                Console.WriteLine(i);
            }

            List<string> slist = new List<string>();

            slist.Add("Pune");
            slist.Add("Mumbai");

            foreach(string s in slist)
            {
                Console.WriteLine(s);
            }

            List<Products> products = new List<Products>();

            products.Add(new Products { prdId = 1, productName = "Pen", price = 20 });
            products.Add(new Products { prdId = 2, productName = "Pen", price = 20 });
            products.Add(new Products { prdId = 3, productName = "Pen", price = 20 });

            foreach (Products pr in products)
            {
                Console.WriteLine(pr);
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Stack Demo ---->>");

            Stack<int> st = new Stack<int>();
            st.Push(10);

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Queue Demo ---->>");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amol");
            queue.Enqueue("Suraj");

            foreach (string s in queue)
            {
                Console.WriteLine(s);
            }

            Queue<Products> qproduct = new Queue<Products>();

            qproduct.Enqueue(new Products { prdId = 1, productName = "Pen", price = 20 });
            qproduct.Enqueue(new Products { prdId = 1, productName = "Pen", price = 20 });

            foreach (Products pr in qproduct)
            {
                Console.WriteLine(pr);
            }


            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Dictionary Demo ---->>");

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(1, "Pune");
            keyValuePairs.Add(2, "Mumbai");
            keyValuePairs.Add(3, "Nagpur");

            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("HashSet Demo ---->>");

            HashSet<int> list1 = new HashSet<int>();

            list1.Add(10);
            list1.Add(20);
            list1.Add(10);
            list1.Add(30);
            list1.Add(40);


            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
