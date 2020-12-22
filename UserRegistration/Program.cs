using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration program");
            Patterns PatternsMatch = new Patterns();
            bool value = PatternsMatch.ValidateFirstName("aema");
            Console.WriteLine(value);
        }
    }
}
