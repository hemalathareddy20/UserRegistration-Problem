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
      public static string REGEX_emailId = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_firstName);  
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_lastName);
        }
        public bool ValidateEmailId(string emailId)
        {
            return Regex.IsMatch(emailId, REGEX_emailId);
        }
    }
}

