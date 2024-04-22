using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class EmployeeForComaparable : IComparable<EmployeeForComaparable>
    {
        private int id;
        private string name;
        private double salary;

        public EmployeeForComaparable(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(EmployeeForComaparable? other)
        {
            if(this.salary > other.salary)
            {
                return 1;
            }
            else if(this.salary < other.salary)
            {
                 return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Employee id : {id}, Name : {name}, Salary : {salary}";
        }

    }

   
}
