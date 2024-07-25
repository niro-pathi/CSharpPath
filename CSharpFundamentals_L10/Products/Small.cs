﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L10.Products
{
    internal class Small: Candle
    {
        public Small(string candleName, string candleType, int availableStock, DateTime expiryDate) :
           base(candleName, candleType, availableStock, expiryDate)
        {
            CandleWeight = 400;
            Price = 49.99;

        }
    }
}
