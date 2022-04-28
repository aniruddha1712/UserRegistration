using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the User Registration Program\n");
                Console.WriteLine("Choose option\n1:First Name\n2:Last Name\n3:Email\n4:Mobile Number\n5:Password\n6:Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
                        Console.Write("Enter FirstName: ");
                        string firstName = Console.ReadLine();
                        ValidateUser.ValidateFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Note: Last name starts with Cap and has minimun 3 characters");
                        Console.Write("Enter LastName: ");
                        string lastName = Console.ReadLine();
                        ValidateUser.ValidateLastName(lastName);
                        break;
                    case 3:
                        Console.WriteLine("Email e.g.abc.xyz@bl.co.in has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions");
                        Console.Write("Enter Your Email: ");
                        string email = Console.ReadLine();
                        ValidateUser.ValidateEmail(email);
                        break;
                    case 4:
                        Console.WriteLine("Note: Country code follow by space and 10 digit number");
                        Console.Write("Enter Your Mobile Number: ");
                        string mobile = Console.ReadLine();
                        ValidateUser.ValidateMobileNumber(mobile);
                        break;
                    case 5:
                        Console.WriteLine("Rule 1: Password must have contains min 8 characters");
                        Console.WriteLine("Rule 2: Password should have at least one Upper Case");
                        Console.WriteLine("Rule 3: Password should have at least one numeric value");
                        Console.WriteLine("Rule 4: Password have exactly one special character");
                        Console.Write("Enter Your Password: ");
                        string password = Console.ReadLine();
                        ValidateUser.ValidatePassword(password);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
