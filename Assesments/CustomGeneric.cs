using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class CustomGeneric<T>
    {
        private T[] array;
        private int size;
        private const int capacity = 10;

        private static int count = 0;
        public CustomGeneric()
        {   
            array = new T[capacity];
            size = 0;
        }

        public void Add(T data)
        {
            if (data != null)
            {
                if (array.Length <= size)
                {   
                    Array.Resize(ref array, array.Length+capacity);
                }
                array[size++] = data;
                count++;
            }
            
        }

        public T[] Print()
        {
            T[] elements = new T[count];
            Array.Copy(array, elements, count);
            return elements;

        }

        public int Count()
        {
            return count;
        }

    }
}
