using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.write a code to demonstrate static keyword with variable, method, constructor and class
*/

namespace Assesments
{
    public class StaticAssignment
    {
        private int id;
        private string name;
        private static string university;
        private static int count;

        
        public StaticAssignment()
        {
            count++;
            id = count;
        }

        public StaticAssignment(string name)
        {
            count++;
            id = count;
            this.name = name;
        }

        public static void University()
        {
            university = "Unipune";
        }

        public string Display()
        {
            return $"Student id : {id}, Name : {name}, University : {university}";
        }
    }
}
