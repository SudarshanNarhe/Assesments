using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Accept email_id from user and check valid or not(should contain @,.)

namespace Assesments.StringAssignments
{
    public class EmailValidate
    {
        public void CheckEmailValidation(string email)
        {
            
            bool isValid = false;

            if (email.Contains('@') && email.Contains('.'))
            {

                if (email.IndexOf('@') > 0 && email.LastIndexOf('@') < email.Length - 1)
                {

                    if (email.IndexOf('.') > email.IndexOf('@') + 1 && email.LastIndexOf('.') < email.Length - 1)
                    {
                        isValid = true;
                    }
                }
            }

                if (isValid)
            {
                Console.WriteLine($"{email} is valid email");
            }
            else
            {
                Console.WriteLine($"{email} is not valid email");
            }
        }
    }
}
