using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L05
{
    internal class Candle
    {
        public string candleName;
        public string waxType;
        public string candleSize;

        public int candleWeight;
        public int availableStock;
        public int reorderLevel = 10;
        public int usedStock;

        public double price;
        public DateTime expiryDate;

        public double GetPrice () 
        { 
            return price; 
        }

        public double GetPrice(int purchasedQty)
        {
            return purchasedQty * price;
        }

        public double SellProduct(int purchasedQty)
        {
            usedStock += purchasedQty;
            availableStock -= purchasedQty;

            Console.WriteLine($"{purchasedQty} {candleName} candles have been sold and current stock is {availableStock}");

            return purchasedQty * price;
        }

        public void DisplayProdcut()
        {
            Console.WriteLine($"Candle : \t{candleName}\nUnit Price: \t{price}\nAvailable Qty: \t{availableStock}");
        }

        
    }
}
