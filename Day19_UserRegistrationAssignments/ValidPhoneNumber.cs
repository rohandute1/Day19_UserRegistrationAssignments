using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignments
{
    internal class ValidPhoneNumber
    {
        public void ValidatePhoneNumberChecker()
        {
            Console.WriteLine("Enter your mobile number:");
            string phoneNumber = Console.ReadLine();

            if (IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("Valid phone number entered.");
            }
            else
            {
                Console.WriteLine("Invalid phone number entered.");
            }
        }
        private bool IsValidPhoneNumber(string mobileNumber)
        {
            string pattern = @"^91\s\d{10}$";
            return Regex.IsMatch(mobileNumber, pattern);
        }
    }
}
