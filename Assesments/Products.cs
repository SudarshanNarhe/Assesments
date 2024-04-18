using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class Products
    {   
       /* private static int count;

        public Products()
        {
            count++;
            prdId = count;
        }*/
        public int prdId { get; set; }
        public string productName { get; set; }

        public double price { get; set; }

        public override string ToString()
        {
            return $"Product Id : {prdId}, Product Name : {productName}, Price : {price}";
        }
    }
}
