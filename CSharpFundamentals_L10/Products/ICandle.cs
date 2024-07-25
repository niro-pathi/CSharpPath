using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L10.Candle
{
    internal interface ICandle
    {
        double GetPrice();
        double GetPrice(int purchasedQty);
        double GetAllPrices(int purchasedQty, out double discountedPrice);
        double SellProduct(int purchasedQty);
        void DisplayProdcut();
        void CheckDiscount();
        void AddProductReview();

    }
}
