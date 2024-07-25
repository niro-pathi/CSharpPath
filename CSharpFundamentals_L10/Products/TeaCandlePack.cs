using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L10.Products
{
    internal class TeaCandlePack: Candle
    {
        public TeaCandlePack(string candleName, string candleType, int availableStock, DateTime expiryDate) :
           base(candleName, candleType, availableStock, expiryDate)
        {
            CandleWeight = 120;
            Price = 19.99;

        }
    }
}
