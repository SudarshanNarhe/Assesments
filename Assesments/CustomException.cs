using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class CustomException : Exception
    {
        public CustomException(string error) : base(error)
        { 

        }
    }

    public class Person
    {
        private int age;
        private string name;

        public void AcceptAge(int age)
        {
            if (age >= 18)
            {
                this.age = age;
            }
            else
            {
                throw new CustomException("Your Age is Below than 18 NOT ALLOWED...!!");
            }
        }
        public void AcceptName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new CustomException("Name is Empty Please Enter Your name...!!");
               
            }
            else
            {
                this.name = name;
            }

        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
