using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignments
{
    internal class ValidatePassword
    {
        public void ValidPasswordChecker()
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Valid password entered.");
            }
            else
            {
                Console.WriteLine("Invalid password entered.");
            }
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
