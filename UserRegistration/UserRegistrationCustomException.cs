using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistrationCustomException : Exception
    {
        public ExceptionType exceptionType;
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND
        }
        public UserRegistrationCustomException(ExceptionType exceptionType,string message):base (message)
        {
            this.exceptionType = exceptionType;

        }
    }
}
