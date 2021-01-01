using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserRegistrationTestCase
{
    [TestClass]
    public class UserRegistrationTest
    {
        [TestMethod]
        public void ValidateFirstNameTest()
        {
            Assert.AreEqual(true, patternsMatch.ValidateFirstName("Hemalatha"));
        }
        [TestMethod]
        public void ValidateLastNameTest()
        {
            Assert.AreEqual(true, patternsMatch.ValidateLastName("Reddy"));
        }
        [TestMethod]
        public void ValidateEmailIdTest()
        {
            Assert.AreEqual(true, patternsMatch.ValidateEmailId("abc.xyz@gmail.co.in"));
        }
        [TestMethod]
        public void ValidateMobileNumberTest()
        {
            Assert.AreEqual(true, patternsMatch.ValidateMobileNumber("91 9123456789"));
        }
        [TestMethod]
        public void ValidatePasswordTest()
        {
            Assert.AreEqual(true, patternsMatch.ValidatePassword("Hema@1234"));
        }

    }
}
