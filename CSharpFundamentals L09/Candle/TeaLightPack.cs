using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L09.Candle
{
    internal class TeaLightPack : TeaLight
    {
        public TeaLightPack(string firstName, string candleType, int availableStock) : base(firstName, candleType, availableStock)
        {
            CandleWeight = 120; 
            Price = 19.99;
        }

        public void AddCandleCaringPack()
        {
            Price += 20.00;
            Console.WriteLine($"Candle Caring pack value of $20 added with this product.");
        }
    }
}
