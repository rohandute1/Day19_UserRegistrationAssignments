using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression problem");
            Console.WriteLine(" Please select program from following");
            Console.WriteLine(" 1.Check first name is valid or not\n 2.Check last name is valid or not\n" +
                " 3.Check email is valid or not\n 4.Check phone number is valid or not\n" +
                " 5.Check password is Strong or not");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ValidFirstName validator = new ValidFirstName();
                    validator.ValidName();
                    break;
                case 2:
                    ValidLastName validLastName = new ValidLastName();
                    validLastName.LastNameCheck();
                    break;
                case 3:
                    ValidEmail validEmail = new ValidEmail();
                    validEmail.ValidateEmailChecker();
                    break;
                case 4:
                    ValidPhoneNumber validNumber = new ValidPhoneNumber();
                    validNumber.ValidatePhoneNumberChecker();
                    break;
                case 5:
                    ValidatePassword validPass = new ValidatePassword();
                    validPass.ValidPasswordChecker();
                    break;


            }
            
            Console.ReadLine(); 
        }
    }
}
