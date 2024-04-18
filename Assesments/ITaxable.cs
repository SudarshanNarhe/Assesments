using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public interface ITaxable
    {
        double PayTax();
    }

    public class Job : ITaxable
    {
        private double salary;
        private double taxamount;

        public Job()
        {
            salary = 20000;
        }
        public double PayTax()
        {
            taxamount = salary * 0.20;
            return taxamount;
        }
    }

    public class Bussiness : ITaxable
    {
        private double salary;
        private double taxamount;

        public Bussiness()
        {
            salary = 20000;
        }
        public double PayTax()
        {
            taxamount = salary * 0.30;
            return taxamount;
        }
    }

}
