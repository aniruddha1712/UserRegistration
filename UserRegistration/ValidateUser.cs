using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class ValidateUser
    {
       public static void ValidateFirstName()
        {
            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
            Console.Write("Enter FirstName: ");
            string input = Console.ReadLine();
            string pattern = "^[A-Z][a-z]{2,}$";
            CheckValidation(input,pattern);
        }
        public static void ValidateLastName()
        {
            Console.WriteLine("Note: Last name starts with Cap and has minimun 3 characters");
            Console.Write("Enter LastName: ");
            string input = Console.ReadLine();
            string pattern = "^[A-Z][a-z]{2,}$";
            CheckValidation(input, pattern);
        }
        public static void ValidateEmail()
        {
            Console.WriteLine("Email e.g.abc.xyz@bl.co.in has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions");
            Console.Write("Enter Your Email: ");
            string input = Console.ReadLine();
            string pattern = "^[a-z0-9][-a-z0-9._+]+@([a-z0-9]+[.])+[a-z]{2,5}([.]+[a-z]{2})*$";
            CheckValidation(input, pattern);
        }
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("Note: Country code follow by space and 10 digit number");
            Console.Write("Enter Your Mobile Number: ");
            string input = Console.ReadLine();
            string pattern = "^[1-9]{1,2}[ ][1-9][0-9]{9}$";
            CheckValidation(input, pattern);
        }
        public static void ValidatePassword()
        {
            Console.WriteLine("Rule 1: Password must have contains min 8 characters");
            Console.WriteLine("Rule 2: Password should have at least one Upper Case");
            Console.WriteLine("Rule 3: Password should have at least one numeric value");
            Console.WriteLine("Rule 4: Password have exactly one special character");
            Console.Write("Enter Your Password: ");
            string input = Console.ReadLine();
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]{1}).{8,}$";
            CheckValidation(input, pattern);
        }
        public static void CheckValidation(string input,string pattern)
        {
            bool res = Regex.IsMatch(input, pattern);
            if (res)
                Console.WriteLine("{0} Valid ", input);
            else
                Console.WriteLine("{0} Invalid ", input);
        }
    }
}
