using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationUnitTest
{
    public class Tests
    {
        Patterns patternsMatch = new Patterns();

        [Test]
        public void GivenFirstName_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateFirstName("Hemalatha"));
        }
        [Test]
        public void GivenLasstName_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateLastName("Reddy"));
        }
        [Test]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateEmailId("abc.xyz@gmail.co.in"));
        }
        [Test]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidateMobileNumber("91 9123456789"));
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatch.ValidatePassword("Hema@1234"));
        }
    }
}