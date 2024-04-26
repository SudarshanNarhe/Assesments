using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor.
Calculate the employee gross salary  & display employee details using ToString() method
HRA- 40% of basic salary
TA – 20% of basic salary
PF -12 % of basic salary
*/

//Use above Employee class, create a static field to auto increment the employee id &
//create static method to display the total object count.


//Use above Employee class, make a constant field as PT(professional tax) as 200.
//Deduct the PT from salary & display the gross salary.


namespace Assesments.ClassAndObjectAssignments
{
    public class Employee
    {
        private static int count = 0;
        private int id;
        private string name;
        private double salary, HRA, TA, PF;

        private const double PT = 200;
        public Employee(string name, double salary)
        {
            count++;
            id = count;
            this.name = name;
            this.salary = salary;
            GrossSalary();
        }

        public void GrossSalary()
        {
            HRA = 0.4 * salary;
            TA = 0.2 * salary;
            PF = 0.12 * salary;

            salary = salary + HRA+ TA + PF - PT ;
        }

        public static void DisplayObjectCount()
        {
            Console.WriteLine($"The total Object count is : {count}");
        }

        public override string ToString()
        {
            return $"Employee Id : {id}, Employee Name : {name}, Salary : {salary}";
        }
    }
}
