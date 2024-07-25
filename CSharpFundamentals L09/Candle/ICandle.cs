using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L09.Candle
{
    internal interface ICandle
    {
        double GetPrice();
        double GetPrice(int purchasedQty);
        double GetPrice(int purchasedQty, ref double discountedPrice);
        double GetAllPrices(int purchasedQty, out double discountedPrice);
        double SellProduct(int purchasedQty);
        void DisplayProdcut();
        void CheckDiscount();

    }
}
