using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create Student class with roll no, name, accept 3 subjects marks from constructor. 
 * Calculate the total marks & percentage. Display student details using ToString()*/

namespace Assesments.ClassAndObjectAssignments
{
    public class Student1
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
      //  public double Percentage { get; set; }

        private int sub1, sub2, sub3;
        private double marks, percentage;
        public Student1(int sub1, int sub2, int sub3)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            CalTotalMarksAndPercentage();
        }

        public void CalTotalMarksAndPercentage()
        {
            marks = sub1 + sub2 + sub3;

            percentage = marks / 3;
        }

        public override string ToString()
        {
            return $"Roll No : {RollNo}, Student Name : {Name}, Total Marks : {marks}, Percentage : {percentage}";
        }
    }
}
