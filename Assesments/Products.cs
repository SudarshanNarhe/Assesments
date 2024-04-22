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

       /* public Products(int prdId, string prdName, double price)
        {
            this.prdId = prdId;
            this.productName = prdName;
            this.price = price;
        }*/
        public override string ToString()
        {
            return $"Product Id : {prdId}, Product Name : {productName}, Price : {price}";
        }
    }
}
