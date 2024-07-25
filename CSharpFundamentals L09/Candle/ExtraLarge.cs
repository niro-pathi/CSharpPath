using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L09.Candle
{
    internal class ExtraLarge : Candle
    {
        public ExtraLarge(string firstName, string candleType, int availableStock) : base(firstName, candleType, availableStock)
        {
            CandleWeight = 400;
            Price = 49.99;
            Console.WriteLine("Enjoy our free shipping with this product.");
        }

        public override void CheckDiscount()
        {
            Console.WriteLine("All our extra large candles get 20% discount.");
        }


    }
}
