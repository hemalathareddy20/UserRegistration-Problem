﻿using System;

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
            Console.WriteLine(PatternsMatch.ValidateMobileNumber("91 9123456789"));
            Console.WriteLine(PatternsMatch.ValidatePassword("12345678"));
        }
    }
}
