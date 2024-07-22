using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L04
{
    internal class Utilities
    {
        public static string WelcomeMessage()
        {
            // String manupulation
            string companyName = "Heavenly Scents Aromatherapy";
            string welcomeMessage = "Welcome to " + companyName + " online shop!";

            return welcomeMessage;
        }

        public static string WelcomeMessage(string firstName, string lastName)
        {
            // String Concatenating
           string fullName = string.Concat(firstName, ", ",lastName);
            // Using string interpolation
            return $"Hello {fullName}" ;
        }
    }
}
