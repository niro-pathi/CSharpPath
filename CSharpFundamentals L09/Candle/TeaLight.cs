using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L09.Candle
{
    internal class TeaLight : Candle
    {
        public TeaLight(string firstName, string candleType, int availableStock) : base(firstName, candleType, availableStock)
        {
            CandleWeight = 40; 
            Price = 4.00;
        }
    }
}
