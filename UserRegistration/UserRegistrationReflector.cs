using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistrationReflector
    {
        public object CreateObjectForValidateUser(string className, string constructor)
        {
            string p = @"." + constructor + "$";
            Match result = Regex.Match(className, p);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type regexSampleType = assembly.GetType(className);
                    var res = Activator.CreateInstance(regexSampleType);
                    return res;
                }
                catch (Exception)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.CLASS_NOT_FOUND, "no class found");
                }
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "no constructor found");
            }
        }
        public object CreateParameterizedConstructor(string classname, string constructorname, string message)
        {
            Type type = typeof(ValidateUser);
            if (type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if (type.Name.Equals(constructorname))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object objectConstructor = constructorInfo.Invoke(new object[] { message });
                    return objectConstructor;
                }
                else
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "no constructor found");
                }
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.CLASS_NOT_FOUND, "no class found");
            }

        }
    }
}
