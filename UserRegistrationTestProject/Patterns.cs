using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTestProject
{
   public class Patterns
    {
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";
        public static string REGEX_FIRSTNAME = "^[A-Z]{3,}$";
        public static string REGEX_EMAIL = "^/(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\r\n\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\r\n\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:\r\n(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])/";
        public static string REGEX_PHONE = "^[0-9]{10}$";
        public bool ValidatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, REGEX_PHONE);
        }
        public void Validate(bool isMatch)
        {
            if (isMatch)
                Console.WriteLine("is validated");
            else
                Console.WriteLine("not validated");
        }
    }
}
