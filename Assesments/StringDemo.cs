using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class StringDemo
    {
        private string str;

        public StringDemo(string str)
        {
            this.str = str;
        }

        // Method to check if the string is empty or null
        public bool IsEmptyOrNull()
        {
            return string.IsNullOrEmpty(str);
        }

        // Method to concatenate two strings
        public string Concat(string other)
        {
            return string.Concat(str, other);
        }

        // Method to get the character at a specific index
        public char CharAt(int index)
        {
            if (index < 0 || index >= str.Length)
                throw new IndexOutOfRangeException("Index out of range");

            return str[index];
        }

        // Method to convert string to char array
        public char[] ToCharArray()
        {
            return str.ToCharArray();
        }

        // Method to convert string to upper case
        public string ToUpper()
        {
            return str.ToUpper();
        }

        // Method to convert string to lower case
        public string ToLower()
        {
            return str.ToLower();
        }

        // Method to find the index of a specific character in the string
        public int IndexOf(char c)
        {
            return str.IndexOf(c);
        }

        // Method to find the last index of a specific character in the string
        public int LastIndexOf(char c)
        {
            return str.LastIndexOf(c);
        }

        // Method to get a substring from the string
        public string Substring(int startIndex, int length)
        {
            return str.Substring(startIndex, length);
        }

        // Method to check if a string contains another string
        public bool Contains(string substr)
        {
            return str.Contains(substr);
        }

        // Method to split the string based on a delimiter
        public string[] Split(char delimiter)
        {
            return str.Split(delimiter);
        }

        // Method to remove leading and trailing whitespace from the string
        public string Trim()
        {
            return str.Trim();
        }
    }

}

