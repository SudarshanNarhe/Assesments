using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    class Student
    {
        private int rollno;
        private string name;
        private static int count;
        public Student()
        {
            count++;
            rollno = count;
            name = "Sudarshan";
        }

        public Student(string name)
        {
            count++;
            this.rollno = count;
            this.name = name;
        }

        public static int GetCount()
        {
            return count;
        }

        public string Display()
        {
            return $"Roll No. : {rollno}, Name : {name}";
        }
    }
}
