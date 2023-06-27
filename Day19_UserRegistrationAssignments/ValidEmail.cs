using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignments
{
    internal class ValidEmail
    {
        public void ValidateEmailChecker()
        {
            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("Valid email address entered.");
            }
            else
            {
                Console.WriteLine("Invalid email address entered.");
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9]+([._%+-][A-Za-z0-9]+)*@[A-Za-z0-9]+(.[A-Za-z]{2,})+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
