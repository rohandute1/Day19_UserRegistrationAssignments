using System;
using System.Text.RegularExpressions;

namespace Day19_UserRegistrationAssignments
{
    public class ValidFirstName
    {
        public void ValidName()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine(); 

            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name entered.");
            }
            else
            {
                Console.WriteLine("Invalid first name entered.");
            }
        }

        private bool IsValidFirstName(string firstName)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(firstName, pattern);
        }
    }
}
