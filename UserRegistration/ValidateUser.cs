using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidateUser
    {
       public static string ValidateFirstName(string input)
        {
            string pattern = "^[A-Z][a-z]{2,}$";
            bool res = Regex.IsMatch(input, pattern);
            if (res)
            {
                Console.WriteLine("{0} Valid ", input);
                return input;
            }

            else
            {
                Console.WriteLine("{0} Invalid ", input);
                return "Invalid";
            }
        }
        public static string ValidateLastName(string input)
        {
            string pattern = "^[A-Z][a-z]{2,}$";
            bool res = Regex.IsMatch(input, pattern);
            if (res)
            {
                Console.WriteLine("{0} Valid ", input);
                return input;
            }

            else
            {
                Console.WriteLine("{0} Invalid ", input);
                return "Invalid";
            }
        }
        public static string ValidateEmail(string input)
        {
            string pattern = "^[a-z0-9][-a-z0-9._+]+@([a-z0-9]+[.])+[a-z]{2,5}([.]+[a-z]{2})*$";
            bool res = Regex.IsMatch(input, pattern);
            if (res)
            {
                Console.WriteLine("{0} Valid ", input);
                return input;
            }

            else
            {
                Console.WriteLine("{0} Invalid ", input);
                return "Invalid";
            }
        }
        public static string ValidateMobileNumber(string input)
        {
            string pattern = "^[1-9]{1,2}[ ][1-9][0-9]{9}$";
            bool res = Regex.IsMatch(input, pattern);
            if (res)
            {
                Console.WriteLine("{0} Valid ", input);
                return input;
            }

            else
            {
                Console.WriteLine("{0} Invalid ", input);
                return "Invalid";
            }
        }
        public static string ValidatePassword(string input)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]{1}).{8,}$";
            bool res = Regex.IsMatch(input, pattern);
            if (res)
            {
                Console.WriteLine("{0} Valid ", input);
                return input;
            }

            else
            {
                Console.WriteLine("{0} Invalid ", input);
                return "Invalid";
            }
        }
    }
}
