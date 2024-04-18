using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public interface ICustomer
    {
        string Print();
    }

    public interface IOrder
    {
        string Print();
    }

    public class Transaction : ICustomer, IOrder
    {
        // by default they are public no need to write it explicity in explicity implenemtation
        string ICustomer.Print()
        {
            return "Customer Details";
        }

        string IOrder.Print()
        {
            return "Order Details";
        }
    }
}
