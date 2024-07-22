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
            // Using escape characters 
            return $"Hello {fullName}\nPlease slect our \"Best Selling\" products from our online shop." ;
        }

        public static bool IsEligibleForFreeShipping(string shippingAddress)
        {

            return shippingAddress.ToUpper() == "MELBOURNE";

        }

        public static int ValidatePostCode(string shippingPostcode)
        {
            // String parsing
            // int postCode = int.Parse(shippingPostcode);

            //TryParse
            int postCode;

            if (int.TryParse(shippingPostcode, out postCode))
            {
                return postCode;
            }
            else
            {
                Console.WriteLine("invalid post code");
                return 0;
            }

        }

    }
}
