using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignments
{
    public class ValidLastName
    {
        public void LastNameCheck()
        {
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            if (IsValidLastName(lastName))
            {
                Console.WriteLine("Valid last name entered.");
            }
            else
            {
                Console.WriteLine("Invalid last name entered.");
            }
        }
        private bool IsValidLastName(string lastName)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(lastName, pattern);
        }
    }
}
