using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create class Product. Add fields like id, name and price. Create properties for each field.
//Use object initializer syntax initialize the object. Print product details using ToString()


//Use above Product class, create Discount method & accept the discount percentage.
//Give discount to the price & Display actual price & discounted price


namespace Assesments.ClassAndObjectAssignments
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public void Discount(double discountPercent)
        {
            double discount = Price * (discountPercent / 100);
            
            Price = Price - discount;
        }
        public override string ToString()
        {
            return $"Produt Id : {Id}, Name : {Name}, Price : {Price}";
        }
    }
}
