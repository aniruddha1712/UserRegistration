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
        public void TestValidateFirstName(string userInput, string expected)
        {
            string actual = ValidateUser.ValidateFirstName(userInput);
            Assert.AreEqual(actual, expected);
        }

        [TestCategory("LastName")]
        [TestMethod]
        [DataRow("Mishra", "Mishra")]
        [DataRow("mishra", "Invalid")]
        public void TestValidateLastName(string userInput, string expected)
        {
            string actual = ValidateUser.ValidateLastName(userInput);
            Assert.AreEqual(actual, expected);
        }

        [TestCategory("Email")]
        [TestMethod]
        [DataRow("aniruddha1712@gmail.com", "aniruddha1712@gmail.com")]
        [DataRow("ani.xyz@yahoo.co.in", "ani.xyz@yahoo.co.in")]
        [DataRow("ani.com", "Invalid")]
        [DataRow("ani12@.com", "Invalid")]
        public void TestValidateEmail(string userInput, string expected)
        {
            string actual = ValidateUser.ValidateEmail(userInput);
            Assert.AreEqual(actual, expected);
        }

        [TestCategory("Mobile No.")]
        [TestMethod]
        [DataRow("91 7864209211", "91 7864209211")]
        [DataRow("911234567893", "Invalid")]
        [DataRow("123477", "Invalid")]
        public void TestValidateMobileNumber(string userInput, string expected)
        {
            string actual = ValidateUser.ValidateMobileNumber(userInput);
            Assert.AreEqual(actual, expected);
        }

        [TestCategory("Password")]
        [TestMethod]
        [DataRow("Anni1234@", "Anni1234@")]
        [DataRow("anni1234", "Invalid")]
        [DataRow("AAAAAA", "Invalid")]
        public void TestValidatePaasword(string userInput, string expected)
        {
            string actual = ValidateUser.ValidatePassword(userInput);
            Assert.AreEqual(actual, expected);
        }
    }
}
