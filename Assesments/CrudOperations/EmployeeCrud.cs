using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.CrudOperations
{
    public class Employee2
    {
        public int id { get; set; }
        public string name { get; set; }

        public double salary { get; set; }

        public Employee2()
        {

        }

        public Employee2(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"Employee Id : {id}, Name : {name}, Salary : {salary}";
        }
    }

    public class EmployeeCrud
    {
        private List<Employee2> employees;

        public EmployeeCrud()
        {
            employees = new List<Employee2>();
        }
        public void AddEmployee(Employee2 employee)
        {
            if (employee != null)
            {
                employees.Add(employee);
                Console.WriteLine("\nEmployee Added Successfully...\n");
            }
           
        }

        public void UpdateEmployee(int id, Employee2 employee)
        {

            int index = FindEmployeeById(id);
            if (index != -1)
            {
                employees[index] = employee;
                Console.WriteLine("\nEmployee Updated Successfully...\n");
            }
        }

        public void DeleteEmployee(int id)
        {
            int index = FindEmployeeById(id);

            if (index != -1)
            {
                employees.RemoveAt(index);
                Console.WriteLine("\nEmployee Deleted Successfully...\n");
            }
        }

        public int FindEmployeeById(int id)
        {
           

            for (int i = 0; i < employees.Count; i++)
            {

                if (id == employees[i].id)
                {
                    Employee2 employee = employees[i];
                    Console.WriteLine(employee);
                    return i;

                }
                
            }
            Console.WriteLine("\nNO Employee found with given Employee Id\n");
            return -1;
        }

        public void FindEmployeeByName(string name)
        {
            Console.WriteLine($"\nDisplay Employees By Name {name}: \n");
            int count = 0;
            foreach (Employee2 employee in employees)
            {
                if(employee.name.ToLower() == name.ToLower())
                {
                    count++;
                    Console.WriteLine(employee);
                }
               
            }
            if(count == 0)
            {
                Console.WriteLine($"No Employees Found with name :  {name} \n");
            }
            Console.WriteLine();
        }

        public void DisplayAllEmployee()
        {
            if (employees.Any())
            {
                Console.WriteLine("\nDisplay all Employees : \n");

                foreach (Employee2 employee in employees)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nThe List is Empty...!!!\n");
            }
           
        }
    }

    public class MainForEmployeeCrud
    {
        static void Main(string[] args)
        {
            int choice;
            EmployeeCrud crud = new EmployeeCrud();

            do
            {
                
                Console.WriteLine("1.Add Employee\n2.Update Employee\n3.Delete Employee\n4.Display Employee By Id\n5.Display Employee By Name\n6.Display All Employee\n7.Exists...!!");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a ID of Employee : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a Name of Employee : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter a Salary of Employee : ");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Employee2 emp = new Employee2();
                        emp.id = id;
                        emp.name = name;
                        emp.salary = salary;
                        crud.AddEmployee(emp);
                        break;

                    case 2:
                        Console.WriteLine("Enter a ID of Employee : ");
                        int updateid = Convert.ToInt32(Console.ReadLine());
                        int res = crud.FindEmployeeById(updateid);
                        if (res != -1)
                        {
                            Console.WriteLine("Enter a Name of Employee : ");
                            string updatedname = Console.ReadLine();
                            Console.WriteLine("Enter a Salary of Employee : ");
                            double updatedsalary = Convert.ToDouble(Console.ReadLine());
                            crud.UpdateEmployee(updateid, new Employee2(updateid, updatedname, updatedsalary));

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter a ID of Employee : ");
                        int deleteid = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(deleteid);
                        break;

                    case 4:
                        Console.WriteLine("Enter a ID of Employee : ");
                        int displayid = Convert.ToInt32(Console.ReadLine());
                        crud.FindEmployeeById(displayid);
                        break;

                    case 5:
                        Console.WriteLine("Enter a Name of Employee : ");
                        string displayname = Console.ReadLine();
                        crud.FindEmployeeByName(displayname);
                        break;
                    case 6:
                        crud.DisplayAllEmployee();
                        break;
                    case 7:
                        Console.WriteLine("Existing....!!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a number between 1 to 6 \n");
                        break;


                }
                

            } while (choice != 7);
        }
    }
}
