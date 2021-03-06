using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UserRegTest
{
    [TestClass]
    public class UserRegistraionTest
    {
        [TestCategory("FirstName")]
        [TestMethod]
        [DataRow("Aniruddha", "Aniruddha")]
        [DataRow("aniruddha", "Invalid")]
        [DataRow("", "first Name should not be empty")]
        public void TestValidateFirstName(string userInput, string expected)
        {
            try
            {
                string actual = ValidateUser.ValidateFirstName(userInput);
                Assert.AreEqual(actual, expected);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("LastName")]
        [TestMethod]
        [DataRow("Mishra", "Mishra")]
        [DataRow("mishra", "Invalid")]
        [DataRow("", "last Name should not be empty")]
        public void TestValidateLastName(string userInput, string expected)
        {
            try
            {
                string actual = ValidateUser.ValidateLastName(userInput);
                Assert.AreEqual(actual, expected);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Email")]
        [TestMethod]
        [DataRow("aniruddha1712@gmail.com", "aniruddha1712@gmail.com")]
        [DataRow("ani.xyz@yahoo.co.in", "ani.xyz@yahoo.co.in")]
        [DataRow("ani.com", "Invalid")]
        [DataRow("ani12@.com", "Invalid")]
        [DataRow("", "email should not be empty")]
        public void TestValidateEmail(string userInput, string expected)
        {
            try
            {
                string actual = ValidateUser.ValidateEmail(userInput);
                Assert.AreEqual(actual, expected);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Mobile No.")]
        [TestMethod]
        [DataRow("91 7864209211", "91 7864209211")]
        [DataRow("911234567893", "Invalid")]
        [DataRow("123477", "Invalid")]
        [DataRow("", "mobile number should not be empty")]
        public void TestValidateMobileNumber(string userInput, string expected)
        {
            try
            {
                string actual = ValidateUser.ValidateMobileNumber(userInput);
                Assert.AreEqual(actual, expected);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Password")]
        [TestMethod]
        [DataRow("Anni1234@", "Anni1234@")]
        [DataRow("anni1234", "Invalid")]
        [DataRow("AAAAAA", "Invalid")]
        [DataRow("", "password should not be empty")]
        public void TestValidatePaasword(string userInput, string expected)
        {
            try
            {
                string actual = ValidateUser.ValidatePassword(userInput);
                Assert.AreEqual(actual, expected);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Reflection")]
        [TestMethod]
        public void TestMethodObjectCreationValidateUser() //with default constructor
        {
            object expected = new ValidateUser();
            UserRegistrationReflector reflector = new UserRegistrationReflector();
            object actual = reflector.CreateObjectForValidateUser("UserRegistration.ValidateUser", "ValidateUser");
            expected.Equals(actual);

        }
        //with parameter constructor
        [TestCategory("Reflection")]
        [TestMethod]
        public void TestMethodParameteizedConstructor()
        {
            object expected = new ValidateUser("UserRegistration");
            UserRegistrationReflector reflector = new UserRegistrationReflector();
            object actual = reflector.CreateParameterizedConstructor("UserRegistration.ValidateUser", "ValidateUser", "UserRegistration");
            actual.Equals(expected);
        }
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("User.ValidateUser", "ValidateUser", "no class found")]
        public void GivenImproperClassNameShouldThrowException(string className, string constructorName,string expected)
        {
            try
            {
                UserRegistrationReflector reflector = new UserRegistrationReflector();
                object actual = reflector.CreateParameterizedConstructor(className, constructorName,expected);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("UserRegistration.ValidateUser", "User", "no constructor found")]
        public void GivenImproperConstructorNameShouldThrowException(string className, string constructorName, string expected)
        {
            try
            {
                UserRegistrationReflector reflector = new UserRegistrationReflector();
                object actual = reflector.CreateParameterizedConstructor(className, constructorName, expected);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}