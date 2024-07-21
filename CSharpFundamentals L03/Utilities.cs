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


        public static double CalculatePrice(int qty, bool expressDelivery)
        {
            double unitPrice = 49.99;
            double deliveryRate = 25.00;

            return (qty * unitPrice) + deliveryRate;
        }

        public static string DeliveryDate()
        {
            DateTime deliveryDate = DateTime.Now.AddDays(5);
            return deliveryDate.ToLongDateString();
        }

        public static string DeliveryDate(bool expressDelivery)
        {
            DateTime deliveryDate = DateTime.Now.AddDays(2);
            return deliveryDate.ToLongDateString();
        }
    }
}
