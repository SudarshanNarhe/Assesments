using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class User1
    {
        private string name, city;

        public User1(string name, string city)
        {
            this.name = name;
            this.city = city;
        }

        public override string ToString()
        {
            return $"Name : {name}, City : {city}";
        }
    }

}
