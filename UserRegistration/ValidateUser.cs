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
        public static string CheckValidation(string input, string pattern)
        {
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
        public static string ValidateFirstName(string input)
        {
            if (input.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "first Name should not be empty");
            }
            else
            {
                string pattern = "^[A-Z][a-z]{2,}$";
                return CheckValidation(input, pattern);
            }
        }
        
        public static string ValidateLastName(string input)
        {
            if (input.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "last Name should not be empty");
            }
            else
            {
                string pattern = "^[A-Z][a-z]{2,}$";
                return CheckValidation(input, pattern);
            }
        }
        public static string ValidateEmail(string input)
        {
            if (input.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "email should not be empty");
            }
            else
            {
                string pattern = "^[a-z0-9][-a-z0-9._+]+@([a-z0-9]+[.])+[a-z]{2,5}([.]+[a-z]{2})*$";
                return CheckValidation(input, pattern);
            }
        }
        public static string ValidateMobileNumber(string input)
        {
            if (input.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "mobile number should not be empty");
            }
            else
            {
                string pattern = "^[1-9]{1,2}[ ][1-9][0-9]{9}$";
                return CheckValidation(input, pattern);
            }
        }
        public static string ValidatePassword(string input)
        {
            if (input.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "password should not be empty");
            }
            else
            {
                string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]{1}).{8,}$";
                return CheckValidation(input, pattern);
            }
        }
    }
}