using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a Java program to input electricity consumption unit and calculate totalelectricity 
 * billaccording to the given condition: 
 * For first 50 units Rs. 0.50/unit 
 * For next 100 units Rs. 0.75/unit 
 * For next 100 units Rs. 1.20/unit 
 * For unit above 250 Rs. 1.50/unit 
 * An additional surcharge of 20% is added to the bill 
*/
namespace Assesments
{
    public class Electricity
    {
        
        public double CalculateBill(int unit)
        {
            double bill;

            if(unit <= 50)
            {
                bill = unit * 0.50;
            }
            else if (unit <= 150)
            {
                bill = 50 * 0.50 + (unit - 50) * 0.75;
            }
            else if (unit <= 250)
            {
                bill = 50 * 0.50 + 100 * 0.75 + (unit - 150) * 1.20;
            }
            else
            {
                bill = 50 * 0.50 + 100 * 0.75 + 100 * 1.20 + (unit - 250) * 1.50;
            }


            return bill = bill * 1.20;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a unit of electricity : ");
            int unit = Convert.ToInt32(Console.ReadLine());
            Electricity el = new Electricity();
            Console.WriteLine("The total bill is : "+el.CalculateBill(unit));


        }
    }
}
