using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
   /* public class Product
    {
        private int code;
        private string name;
        private double price;

        public int Code
        {
            set { code = value; }
            get { return code; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }  
            get { return price; }
        }
    }*/

    public class Product
    {   
        public int Code { get; set; }  // if we didn't mentioned set then it is readonly property we can acess only 

        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Code = 34;
        }

        public override string ToString()
        {
            return $"Code : {Code}, Name : {Name}, Price : {Price}";
        }
    }
}
