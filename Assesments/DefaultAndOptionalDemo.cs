using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class Users
    {
        private int id;
        private string name;
        private bool isCustomer;
        private string city;

        public void Accept(int id,  string name, bool isCustomer = true, string city="India")
        {
            this.id = id;
            this.name = name;
            this.isCustomer = isCustomer;
            this.city = city;
        }

        public override string ToString()
        {
            return $"ID : {id}, Name :{name}, Customer : {isCustomer}, City : {city}";
        }
    }
}
