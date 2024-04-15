using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.

namespace Assesments
{
    internal class ConvertTempreture
    {
        public static void convertFromDegreeToFarehn(float degree)
        {
            float fahren = (9* degree/5)+ 32;
            Console.WriteLine(degree+ " °C ----->>> " + fahren+ " °F");
        }

        public static void convertFromFahrenToDegree(float fahren)
        {
            float degree = (fahren - 32) * 5 / 9;
            Console.WriteLine(fahren+ " °F ------>>> " + degree+ " °C");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a which conversion you want \n1.Celsius to Fahrenheit \n2.Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter a tempreture in Fahrenheit");
                    float fahren = Convert.ToSingle(Console.ReadLine());
                    convertFromDegreeToFarehn(fahren);
                    break;
                case 2:
                    Console.WriteLine("Enter a tempreture in Celcius");
                    float cels = Convert.ToSingle(Console.ReadLine());
                    convertFromFahrenToDegree(cels);
                    break;
                default: Console.WriteLine("Please enter a proper number while choosing an option");
                    break;
            }
        }
    }
}
