using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.ClassAndObjectAssignments
{
    internal class MainMethodForClassObject
    {
        static void Main(string[] args)
        {
            //1. Employee and salary
            /*
                        Employee e1 = new Employee(11, "Sudarshan", 23000);
                        Console.WriteLine(e1);
                        Employee e2 = new Employee(12, "Suraj", 34000);
                        Console.WriteLine(e2);
                        Employee e3 = new Employee(13, "Yogesh", 53000);
                        Console.WriteLine(e3);
                        Employee e4 = new Employee(14, "Aadarsh", 73000);
                        Console.WriteLine(e4);
            */

            //2.,3 Product 
            /*
                        Product product = new Product();

                        product.Id = 1;
                        product.Name = "Mouse";
                        product.Price = 2300;

                        Console.WriteLine(product);

                        product.Discount(12);
                        Console.WriteLine("After discount of 12% ");
                        Console.WriteLine(product);

                        Product product1 = new Product();

                        product1.Id = 2;
                        product1.Name = "Laptop";
                        product1.Price = 73000;

                        Console.WriteLine(product1);

                        product1.Discount(17);
                        Console.WriteLine("After discount of 15% ");
                        Console.WriteLine(product1);
            */
            //4.Student
            /*
                        Student s1 = new Student();
                        s1.RollNo = 101;
                        s1.Name = "Sudarshan";
                        s1.Percentage = 89.98;
                        Console.WriteLine(s1);

                        Student s2 = new Student();
                        s2.RollNo = 102;
                        s2.Name = "Suraj";
                        s2.Percentage = 79.58;
                        Console.WriteLine(s2);

                        Student s3 = new Student();
                        s3.RollNo = 103;
                        s3.Name = "Nitin";
                        s3.Percentage = 93.37;
                        Console.WriteLine(s3);

            */

            //5,6.Employee Static for id and object count and also PT as const which is deduct from gross salary
           /* 
            Employee e1 = new Employee("Sudarshan", 23000);
            Console.WriteLine(e1);
            Employee e2 = new Employee("Suraj", 34000);
            Console.WriteLine(e2);
            Employee e3 = new Employee("Yogesh", 53000);
            Console.WriteLine(e3);
            Employee e4 = new Employee("Aadarsh", 73000);
            Console.WriteLine(e4);

            Employee.DisplayObjectCount();
*/          


            //7. Student calculate marks and percentage 
            Student1 s1 = new Student1(89,67,97);
            s1.RollNo = 11;
            s1.Name = "Sudarshan";
           Console.WriteLine(s1);

            Student1 s2 = new Student1(76, 96, 88);
            s2.RollNo = 12;
            s2.Name = "Suraj";
            Console.WriteLine(s2);

            Student1 s3 = new Student1(72, 71, 63);
            s3.RollNo = 13;
            s3.Name = "Yogesh";
            Console.WriteLine(s3);

            Student1 s4 = new Student1(73, 87, 81);
            s4.RollNo = 14;
            s4.Name = "Aadarsh";
            Console.WriteLine(s4);



        }

    }
}
