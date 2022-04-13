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
