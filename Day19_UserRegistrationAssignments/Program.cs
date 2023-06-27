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
            Console.WriteLine(" 1.Valid First name\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ValidFirstName validator = new ValidFirstName();
                    validator.ValidName();
                    break;
            }
            
            Console.ReadLine(); 
        }
    }
}
