/*

Console.WriteLine("Hello, World!");
int num1 = 40;
int num2 = 60;
char ch = 's';
string str = "Sudarshan";
double d = 56;
float f = 78.34f;

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(str);
Console.WriteLine(ch);
Console.WriteLine(d);
Console.WriteLine(f);*/

using Assesments;

// Employee Class With Methods
/*
Employee emp = new Employee();

emp.Assign();
emp.CalSalary();
string res=emp.Display();
Console.WriteLine(res);

Employee emp2 = new Employee();

emp2.Accept(2, "Suraj", 3000, 1200, 890);
emp2.CalSalary();
Console.WriteLine(emp2.Display());
*/


//Student class with Constructor



/*Student std = new Student();
Console.WriteLine(std.Display());

Student std1 = new Student("Yogesh");
Console.WriteLine(std1.Display());

Student std2 = new Student("Suraj");
Console.WriteLine(std2.Display());

Console.WriteLine(Student.GetCount());*/

// Date class with Constructor
/*
Date d = new Date();
Console.WriteLine(d.Display());

Date d1 = new Date("Tuesday", "May", 2024);
Console.WriteLine(d1.Display());

 */

// Product class with Properties 

/*
//Property initializer syntax
Product p1 = new Product();
p1.Code = 101; 
p1.Name = "Laptop"; // internally it call set method
p1.Price = 67000;

Console.WriteLine($"code : {p1.Code}, name : {p1.Name}, price : {p1.Price}");

//Object initializer syntax
Product p2 = new Product { Code = 501, Name = "Mouse", Price = 899 };

Console.WriteLine($"code : {p2.Code}, name : {p2.Name}, price : {p2.Price}");

*/


//Property class with Book Class
/*
Book b1 = new Book();
b1.Bookid = 11;
b1.BookName = "Mrutunjay";
b1.Price = 1340;

Console.WriteLine($"Book id : {b1.Bookid}, Book Name : {b1.BookName}, Price : {b1.Price}");

Book b2 = new Book { Bookid = 105, BookName = "Wings Of Wire", Price = 780 };

Console.WriteLine($"Book id : {b2.Bookid}, Book Name : {b2.BookName}, Price : {b2.Price}");
*/

// Assignmets On student class
/*
Student1 std = new Student1();
std.AcceptDetails(11, "Sudarshan", 78, 89, 76);
std.CalculatePer();
Console.WriteLine(std.DisplayDetails());

Student1 std1 = new Student1();
std1.AcceptDetails(12, "Suraj", 89, 99, 86);
std1.CalculatePer();
Console.WriteLine(std1.DisplayDetails());
*/

// Assignments On Shopping class
/*
Shopping sp = new Shopping();
sp.Acceptdetails(101, "Laptop", 55000, 2);
sp.CalculateBill();
//Console.WriteLine(sp.DisplayDetails());

Shopping sp1 = new Shopping();
sp1.Acceptdetails(102, "Mouse", 5000, 0);
sp1.CalculateBill();
//Console.WriteLine(sp1.DisplayDetails());

Shopping sp2 = new Shopping();
sp2.Acceptdetails(103, "Mobile", 15000, 3);
sp2.CalculateBill();

*/


//Inheritance and Polymorphysm
/*
Manager mn = new Manager(102,"Sudarshan",34000,6000,3000,45000);
mn.CalSalary();
Console.WriteLine(mn.Display());

Employee emp = new Employee(101,"Suraj",56000,5600,2500);
emp.CalSalary();
Console.WriteLine(emp.Display());

//Dynamic binding/ run time binding it will call the manger methods at run time but at compile time
// it will show employees methods using this type we can access all the methods of all childs using 
// parent class Object

Employee e2 = new Manager(103, "Yogesh", 89000, 6000, 3400, 3400);
e2.CalSalary();
Console.WriteLine(e2.Display());
*/

//Abstract class 
/*
Circle c1 = new Circle(5);
c1.CalculateArea();
c1.Show();
Console.WriteLine(c1.Display());

Circle c2 = new Circle(7.2);
c2.CalculateArea();
Console.WriteLine(c2.Display());

Rectangle r = new Rectangle(23, 15);
r.CalculateArea();
Console.WriteLine(r.Display());
*/

//Method overloading 

Calculation cal = new Calculation();

double res= cal.Addition(12, 34);
Console.WriteLine("Addition is : "+res);

double res1 = cal.Addition(12, 34, 89);
Console.WriteLine("Addition is : " + res1);

double res2 = cal.Addition(24, 76.30);
Console.WriteLine("Addition is : " + res2);

