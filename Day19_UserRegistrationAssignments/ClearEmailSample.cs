using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignments
{
    internal class ClearEmailSample
    {
        public void EmailSamplesChecker()
        {
            Console.WriteLine("Clearing email samples...");
            string[] emailSamples = {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com",
            "abc",
            "abc@.com.my",
            "abc123@gmail.a",
            "abc123@.com",
            "abc123@.com.com",
            ".abc@abc.com",
            "abc()*@gmail.com",
            "abc@%*.com",
            "abc..2002@gmail.com",
            "abc.@gmail.com",
            "abc@abc@gmail.com",
            "abc@gmail.com.1a",
            "abc@gmail.com.aa.au"
        };

            foreach (string email in emailSamples)
            {
                if (IsValidEmail(email))
                {
                    Console.WriteLine($"Valid email: {email}");
                }
                else
                {
                    Console.WriteLine($"Invalid email: {email}");
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9]+([._%+-][A-Za-z0-9]+)*@[A-Za-z0-9]+(\.[A-Za-z]{2,})+$";
            bool hasMultipleAtSymbols = email.IndexOf('@') != email.LastIndexOf('@');
            return Regex.IsMatch(email, pattern) && !hasMultipleAtSymbols;
        }
    }
}
