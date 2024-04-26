using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create class Student, with roll no , name , percentage auto implemented properties.
//Use property initialize syntax to assign the values. Print the student details


namespace Assesments.ClassAndObjectAssignments
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public override string ToString()
        {
            return $"Roll No : {RollNo}, Student Name : {Name}, Percentage : {Percentage}";
        }
    }
}
