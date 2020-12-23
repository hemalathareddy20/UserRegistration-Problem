using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration program");
            Patterns PatternsMatch = new Patterns();
            Console.WriteLine("FirstName:" + PatternsMatch.ValidateFirstName("Hema"));
            Console.WriteLine("LastName:" + PatternsMatch.ValidateLastName("Latha"));
            Console.WriteLine("EmailId:" + PatternsMatch.ValidateEmailId("abc.xyz@gmail.co.in"));
            Console.WriteLine("MobileNumber:" + PatternsMatch.ValidateMobileNumber("91 9123456789"));
            Console.WriteLine("Password:" + PatternsMatch.ValidatePassword("Hema@1234"));
        }
    }
}
