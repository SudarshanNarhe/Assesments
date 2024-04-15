using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class Manager : Employee
    {
        private double foodallownce;

        public Manager() : base()
        {

        }

        public Manager(int id, string empname, double bs, double hra, double pf, double foodallownce) : 
            base(id,empname,bs,hra,pf)
        {
            this.foodallownce = foodallownce;
        }

        //Calculate salary for manager

        public override void CalSalary()
        {
            gross = (bs + hra + foodallownce) - pf;
        }

        public override string Display()
        {
            return $"Manager Salary ---->> empid = {empid}, Emp Name = {empname}, Salary = {gross}";
        }
    }
}
