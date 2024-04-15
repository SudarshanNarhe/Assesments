using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*write a code to create a shopping class which contain product id, product name, price, quantity
create first method to accept the product details 
create a second method to calculate a total bill if the quantity is greater than zero otherwise display error msg
create a third method to show all the shopping details including total bill*/

namespace Assesments
{
    public class Shopping
    {
        private int prdid;
        private string prdname;
        private double price,bill;
        private int quantity;

        public void Acceptdetails(int prdid, string prdname, double price, int quntity)
        {
            this.prdid = prdid;
            this.prdname = prdname;
            this.price = price;
            this.quantity = quntity;
        }

        public void CalculateBill()
        {
            if (this.quantity > 0)
            {
                bill = quantity * price;
                Console.WriteLine(DisplayDetails());
            }
            else
            {   
                Console.WriteLine("Cannot Calculate bill because Quantity is zero.");
                
            }
        }

        public string DisplayDetails()
        {
            return $"Product id : {prdid}, Product Name : {prdname},Price : {price}, Quantity : {quantity}, Total Bill : {bill}";
        }
    }
}
