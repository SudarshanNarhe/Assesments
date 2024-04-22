using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class StackAndQueueDemo
    {
        static void Main(string[] args)
        {   

            //Stack Demo

            Stack st = new Stack();

            st.Push(10);
            st.Push(20);
            st.Push(30);

            // to remove top element
            st.Pop();

            Console.WriteLine($"Top element on stack {st.Peek()}");
            Console.WriteLine($"Total elements {st.Count}");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            // Queue Demo

            Queue queue = new Queue();
            queue.Enqueue("Hello");
            queue.Enqueue("Good Morning");
            queue.Enqueue("Bye");

            //remove --> first element will be removed "Hello"
            queue.Dequeue();

            // select first element
            Console.WriteLine($"first element in the queue {queue.Peek()}");
            // to get total elements
            Console.WriteLine($"total elements {queue.Count}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
