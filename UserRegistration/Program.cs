using System;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration program");
            Patterns patternsMatch = new Patterns();
            Console.WriteLine("FirstName:" + patternsMatch.ValidateFirstName("Hema"));
            Console.WriteLine("LastName:" + patternsMatch.ValidateLastName("Latha"));
            Console.WriteLine("EmailId:" + patternsMatch.ValidateEmailId("abc.xyz@gmail.co.in"));
            Console.WriteLine("MobileNumber:" + patternsMatch.ValidateMobileNumber("91 9123456789"));
            Console.WriteLine("Password:" + patternsMatch.ValidatePassword("Hema@1234"));
        }
    }
}
