using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
     public class Employee
    {
        protected int empid;
        protected string empname;
        protected double bs, hra, pf, gross;

        public Employee()
        {
            empid = 1;
            empname = "Sudarshan";
            bs = 5000;
            hra = 2000;
            pf = 1500;
        }

        public void Assign()
        {
            empid = 1;
            empname = "Sudarshan";
            bs = 5000;
            hra = 2000;
            pf = 1500;
        }

        public Employee(int id, string empname, double bs, double hra, double pf)
        {
            this.empid = id;
            this.empname = empname;
            this.bs = bs;
            this.hra = hra;
            this.pf = pf;
        }

        public void Accept(int id, string empname, double bs, double hra, double pf)
        {
            this.empid = id;
            this.empname = empname;
            this.bs = bs;
            this.hra = hra;
            this.pf = pf;
        }

        public virtual void CalSalary()
        {
            gross = (bs + hra) - pf;
        }

        public virtual string Display()
        {
            return $"Employee Salary ---->>  empid = {empid}, Emp Name = {empname}, Salary = {gross}";
        }
    }
}
