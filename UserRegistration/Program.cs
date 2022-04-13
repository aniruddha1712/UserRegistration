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
            Console.WriteLine("Welcome to the User Registration Program\n");
            ValidateUser.ValidateFirstName();
            ValidateUser.ValidateLastName();
            Console.ReadLine();
        }
    }
}
