using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Patterns
    {
      public static string REGEX_firstName = "^[A-Z]{1}[a-z]{2,}";
      public static string REGEX_lastName = "[A-Z]{1}[a-z]{2,}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_firstName);  
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_lastName);
        }
    }
}

