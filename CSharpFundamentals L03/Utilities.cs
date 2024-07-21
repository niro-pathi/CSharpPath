using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L03
{
    internal class Utilities
    {
        public static double CalculatePrice(int qty)
        {
            double unitPrice = 49.99;

            return qty * unitPrice;
        }

        public static string DeliveryDate()
        {
            DateTime deliveryDate = DateTime.Now;
            return deliveryDate.ToLongDateString();
        }

    }
}
