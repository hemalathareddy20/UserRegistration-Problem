using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration program");
            Patterns PatternsMatch = new Patterns();
            Console.WriteLine(PatternsMatch.ValidateFirstName("Hema"));
            Console.WriteLine(PatternsMatch.ValidateLastName("Latha"));
            Console.WriteLine(PatternsMatch.ValidateEmailId("abc.xyz@gmail.co.in"));
        }
    }
}
