using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration program");
            Patterns PatternsMatch = new Patterns();
            bool value = PatternsMatch.ValidateFirstName("Hema");
            bool value1 = PatternsMatch.ValidateLastName("Latha");
            Console.WriteLine(value);
            Console.WriteLine(value1);
        }
    }
}
