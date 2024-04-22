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
using System.Collections;

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

/*
Calculation cal = new Calculation();

double res= cal.Addition(12, 34);
Console.WriteLine("Addition is : "+res);

double res1 = cal.Addition(12, 34, 89);
Console.WriteLine("Addition is : " + res1);

double res2 = cal.Addition(24, 76.30);
Console.WriteLine("Addition is : " + res2);

*/

// Assignments on overloading

/*
CalculateAreas ca = new CalculateAreas();

Console.WriteLine("Enter a Proper choice for calculate a area : \n1.Rectangle\n2.Circle\n3.Square\n4.Triangle");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("Enter a length of rectangle : ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a width of rectangle : ");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = ca.CalculateArea(length, width);
        Console.WriteLine("Area of a rectangle is : "+area);
        break;
    case 2:
        Console.WriteLine("Enter a radius of a circle : ");
        int radius = Convert.ToInt32(Console.ReadLine());
        double area1 = ca.CalculateArea(radius);
        Console.WriteLine("Area of a circle is : " + area1);
        break;
    case 3:
        Console.WriteLine("Enter a side of square : ");
        double side = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of a Sqaure is : "+ca.CalculateArea(side));
        break;
    case 4:
        Console.WriteLine("Enter a breadth of triangle : ");
        double breadth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a height of trianlge : ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of a triangle is : " + ca.CalculateArea(breadth,height));
        break;
    default : Console.WriteLine("Please enter a proper choice");
        break;
}

*/

/*
Console.WriteLine("Addition is : "+ ArthmeticOperations.Addition(12.34, 32.12));
Console.WriteLine("Addition is : " + ArthmeticOperations.Addition(53, 50));
Console.WriteLine("Subraction is : " + ArthmeticOperations.Subtraction(87.23, 23.21));
Console.WriteLine("Subraction is : " + ArthmeticOperations.Subtraction(872, 123));
Console.WriteLine("Multiplication is : " + ArthmeticOperations.Multiplication(17.2, 15.8));
Console.WriteLine("Multiplication is : " + ArthmeticOperations.Multiplication(12, 9));
Console.WriteLine("Division is : " + ArthmeticOperations.Division(123.85, 3.5));
Console.WriteLine("Division is : " + ArthmeticOperations.Division(64, 3));

*/

/*
StaticAssignment s1 = new StaticAssignment("Sudarshan");
StaticAssignment.University();
Console.WriteLine(s1.Display());

*/

// Interface 

/*
Job j1 = new Job();
Console.WriteLine("Tax amount for job : "+j1.PayTax());

Bussiness b1 = new Bussiness();
Console.WriteLine("Tax amount for bussiness : "+b1.PayTax());
*/

// To call explicit interface we have to call like this interface as ref and class name 

/*
ICustomer c1 = new Transaction();
Console.WriteLine(c1.Print());

IOrder o1 = new Transaction();
Console.WriteLine(o1.Print());
*/

// Partial Class
/*
Calc c = new Calc();

Console.WriteLine($"Addition is : {c.Add(10,12)}");

c.Sub(20, 12);
c.Multi(5, 3);

*/

// Array Examples

/*
//first Syntax
int[] arr = new int[5];
arr[0] = 12;
arr[1] = 13;
*//*arr[2] = 14;*//*
arr[3] = 15;
arr[4] = 16;

Console.WriteLine(arr[2]);

// using traditional for loop
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"arr[{i}] ---->> {arr[i]}");
}

// using for each
foreach (int i in arr)
{
    Console.WriteLine(i);
}

Console.WriteLine("------------------------");
//second Syntax

string[] name = { "Suraj", "Sudarshan", "Yogesh", "Aadarsh" };

foreach(string s in name)
{
    Console.WriteLine(s);
}
Console.WriteLine("------------------------");
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

Console.WriteLine("------------------------");

double[] numbers = new double[7] {2.3,56.43,56.12,23.67,89.34,98,12.65};

foreach (double n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("------------------------");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
*/

// Array of objects

/*
Products[] prds;
Console.WriteLine("Enter how many products you have to add : ---->> ");
int counts = Convert.ToInt32(Console.ReadLine());
prds=new Products[counts];


for (int i = 0; i < prds.Length; i++)
{
    Products product = new Products();
    Console.WriteLine($"Enter Id of {i+1} Product : ");
    product.prdId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter Name of {i + 1} Product : ");
    product.productName =Console.ReadLine();
    Console.WriteLine($"Enter Price of {i + 1} Product : ");
    product.price = Convert.ToDouble(Console.ReadLine());
    prds[i]= product;
}

//for Display 

foreach(Products pr in prds)
{
    Console.WriteLine(pr);
}
*/

//Methods
/*
int[] arr1 = new int[] { 80, 45, 12, 78, 1 };

//Print as it is 
Console.WriteLine("Array ------>>");
foreach (int i in arr1)
{
    Console.WriteLine(i);
}

//sorting
Console.WriteLine("Sorted ------>>");
Array.Sort(arr1);

foreach (int i in arr1)
{
    Console.WriteLine(i);
}

//Reverse
Console.WriteLine("Reverse ------>>");
Array.Reverse(arr1);
foreach (int i in arr1)
{
    Console.WriteLine(i);
}

//copy
int[] arr2 = new int[3];
Array.Copy(arr1,2,arr2,0,3);
Console.WriteLine("Copy ------>>");
foreach (int i in arr2)
{
    Console.WriteLine(i);
}

//Clear
Array.Clear(arr1);
Console.WriteLine("After clear ----->>");
foreach (int i in arr1)
{
    Console.WriteLine(i);
}
*/

//All methods For String type array
/*
string[] str = new string[] { "suraj", "yogesh", "sudarshan", "aadarsh", "ravi" };

//Print as it is 
Console.WriteLine("Array ------>>");
foreach (string s in str)
{
    Console.WriteLine(s);
}


//sorting
Console.WriteLine("Sorted ------>>");
Array.Sort(str);

foreach (string s in str)
{
    Console.WriteLine(s);
}

//Reverse
Console.WriteLine("Reverse ------>>");
Array.Reverse(str);
foreach (string s in str)
{
    Console.WriteLine(s);
}

//copy
string[] str2 = new string[3];
Array.Copy(str, 2, str2, 0, 3);
Console.WriteLine("Copy ------>>");
foreach (string s in str2)
{
    Console.WriteLine(s);
}

//Clear
Array.Clear(str,2,2);
Console.WriteLine("After clear ----->>");
foreach (string s in str)
{
    Console.WriteLine(s);
}
*/

// 2D Array

// Addition of 3*3 matrix by accept data from user

/*
int[,] mat1 = new int[3, 3];

int[,] mat2 = new int[3, 3];

for (int i = 0; i <mat1.GetLength(0); i++)
{
    for (int j = 0; j < mat1.GetLength(1); j++)
    {
        Console.WriteLine($"Enter a element for position [{i},{j}] : ");
        int num = Convert.ToInt32(Console.ReadLine());
        mat1[i, j] = num;
    }
}

for (int i = 0; i < mat2.GetLength(0); i++)
{
    for (int j = 0; j < mat2.GetLength(1); j++)
    {
        Console.WriteLine($"Enter a element for position [{i},{j}] : ");
        int num = Convert.ToInt32(Console.ReadLine());
        mat2[i, j] = num;
    }
}

Console.WriteLine("Print first matrix ---->> ");

foreach (int i in mat1)
{
    Console.Write(i+" , ");
}

Console.WriteLine("\nPrint second matrix ---->> ");

foreach (int i in mat2)
{
    Console.Write(i+" , ");
}

//Addition

Console.WriteLine("\nAddition of 2 matrices is ------>> ");

int[,] addition = new int[3, 3];

for (int i = 0; i < addition.GetLength(0); i++)
{
    for (int j = 0; j < addition.GetLength(1); j++)
    {
        addition[i, j] = mat1[i,j] + mat2[i,j];
        Console.Write(addition[i,j]+" , ");
    }
}

*/

// String Demo

/*
string testStr = "Hello, World!";
StringDemo sm = new StringDemo(testStr);

Console.WriteLine("Is string empty or null: " + sm.IsEmptyOrNull());
Console.WriteLine("Concatenated string: " + sm.Concat(" Welcome!"));
Console.WriteLine("Character at index 7: " + sm.CharAt(7));
Console.WriteLine("String to char array: " + string.Join(",", sm.ToCharArray()));
Console.WriteLine("String to upper case: " + sm.ToUpper());
Console.WriteLine("String to lower case: " + sm.ToLower());
Console.WriteLine("Index of 'o': " + sm.IndexOf('o'));
Console.WriteLine("Last index of 'o': " + sm.LastIndexOf('o'));
Console.WriteLine("Substring from index 7 to 12: " + sm.Substring(7, 5));
Console.WriteLine("Contains 'World': " + sm.Contains("World"));
Console.WriteLine("Split by ',': " + string.Join(",", sm.Split(',')));
Console.WriteLine("Trimmed string: " + sm.Trim());
Console.WriteLine($"address of str {testStr.GetHashCode()}");
*/

// Custom Generic Collection
/*
CustomGeneric<int> list = new CustomGeneric<int>();
list.Add(225);
list.Add(345);
list.Add(73);
list.Add(21);
list.Add(11);
list.Add(99);
list.Add(12);
list.Add(90);
list.Add(11);
list.Add(90);
list.Add(12);
list.Add(90);
list.Add(11);


Array l=list.Print();
foreach(var item in l)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Total Number of elements in list are : {list.Count()}");
*/

// IEnumerable interface concept with custom class
/*
Team ind = new Team();

foreach(Player p in ind)
{
    Console.WriteLine(p);
}

Player virat = new Player("Virat",3000);
Player rohit = new Player("Rohit",5600);
Console.WriteLine(virat);
Console.WriteLine(rohit);
Console.WriteLine();
int result = CompareTo(virat, rohit);

if (result == 1)
{
    Console.WriteLine("Virat has more runs than rohit");
}
else if (result == -1)
{
    Console.WriteLine("virat has less runs than rohit");
}
else
{
    Console.WriteLine("both have equal runs");
}

*/

//IComaparable interface
/*
EmployeeForComaparable emp = new EmployeeForComaparable(12, "Sudarshan", 45000);
EmployeeForComaparable emp1 = new EmployeeForComaparable(13, "Suraj", 55000);

Console.WriteLine(emp);
Console.WriteLine(emp1);
Console.WriteLine();
int result = emp.CompareTo(emp1);
if(result == 1)
{
    Console.WriteLine("Sudarshan has more salary than Suraj ");
}
else if(result == -1)
{
    Console.WriteLine("Suraj has more salary than Sudarshan ");
}
else
{
    Console.WriteLine("Both have same salary");
}
*/

// Comparer interface 
/*
Player virat = new Player("Virat",3000);
Player rohit = new Player("Rohit",5600);
Console.WriteLine(virat);
Console.WriteLine(rohit);
Console.WriteLine();
PlayerComapare obj = new PlayerComapare();

int result = obj.Compare(virat, rohit);

if (result == 1)
{
    Console.WriteLine("Virat has more runs than rohit");
}
else if (result == -1)
{
    Console.WriteLine("virat has less runs than rohit");
}
else
{
    Console.WriteLine("both have equal runs");
}
*/
