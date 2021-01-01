using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserRegistrationUnitTest
{
    [TestClass]
    public class UserRegistrationUnitTestCase
    {
        readonly Patterns patternsMatch = new Patterns();
        [TestMethod]
        public void GivenFirstName_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateFirstName("Hemalatha"));
        }
        [TestMethod]
        public void GivenLasstName_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateLastName("Reddy"));
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateEmailId("abc.xyz@gmail.co.in"));
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateMobileNumber("91 9123456789"));
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidatePassword("Hema@1234"));
        }
    }
}
