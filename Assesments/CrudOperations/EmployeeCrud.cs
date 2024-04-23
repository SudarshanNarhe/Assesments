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
        EmployeeCrud crud;
        public void AddEmployee(Employee2 employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(int id, Employee2 employee)
        {

            int index = crud.FindEmployeeById(id);
            if (index != -1)
            {
                employees[index] = employee;
                Console.WriteLine("Employee Updated Successfully...");
            }
        }

        public void DeleteEmployee(int id)
        {
            int index = crud.FindEmployeeById(id);

            if (index != -1)
            {
                employees.RemoveAt(index);
                Console.WriteLine("Employee Updated Successfully...");
            }
        }

        public int FindEmployeeById(int id)
        {
            int index = 0;

            for (int i = 0; i < employees.Count; i++)
            {

                if (id == employees[i].id)
                {
                    Employee2 employee = employees[i];
                    Console.WriteLine(employee);
                    i = index;

                }
                else
                {
                    Console.WriteLine("NO Employee found with given User");
                    index = -1;
                }
            }
            return index;
        }

        public void DisplayAllEmployee()
        {
            foreach (Employee2 employee in employees)
            {
                Console.WriteLine(employee);
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
                Console.WriteLine("1.Add Employee\n2.Update Employee\n3.Delete Employee\n4.Display Employee By Id\n5.Display All Employee\n6.Exists...!!");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a ID of Employee : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a Name of Employee : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter a Salary of Employee : ");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        crud.AddEmployee(new Employee2(id, name, salary));
                        break;

                    case 2:
                        Console.WriteLine("Enter a ID of Employee : ");
                        int updateid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a Name of Employee : ");
                        string updatedname = Console.ReadLine();
                        Console.WriteLine("Enter a Salary of Employee : ");
                        double updatedsalary = Convert.ToDouble(Console.ReadLine());
                        crud.UpdateEmployee(updateid, new Employee2(updateid, updatedname, updatedsalary));
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
                        Console.WriteLine("Display all Employees : ");
                        crud.DisplayAllEmployee();
                        break;
                    case 6:
                        Console.WriteLine("Existing....!!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 to 6 ");
                        break;


                }

            } while (choice != 6);
        }
    }
}
