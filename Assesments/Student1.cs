using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * write a code to create student class, student contain id, name, 3 sub marks 
create first method to accept student details 
create second method to calculate the perentage of 3 sub marks
create a third method to display all the student details including percentage
 */

namespace Assesments
{
    public class Student1
    {
        private int stdid;
        private string sname;
        private double sub1, sub2, sub3, per;

        public void AcceptDetails(int stdid, string name, double sub1, double sub2, double sub3)
        {
            this.stdid = stdid;
            this.sname = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }

        public void CalculatePer()
        {
           per = (sub1 + sub2 + sub3)/3;

        }

        public string DisplayDetails()
        {
            return $"Student id : {stdid}, Student Name : {sname}, Percentage : {per}";
        }
    }
}
