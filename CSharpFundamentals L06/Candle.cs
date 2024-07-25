using CSharpFundamentals_L06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L06
{
    internal class Candle
    {
        public string candleName;
        public string waxType;
       
        public int candleWeight;
        public int availableStock;
        public int reorderLevel = 10;
        public int usedStock;

        public double price;
        public DateTime expiryDate;

        // Using enumerations
        public CandleSize candleSize;


        const int reorderQty = 5;

        public Candle(string name, string type, CandleSize size) : this(name,type,size,10)
        {
     
        }

        public Candle(string name, string type, CandleSize size, int stock)
        {
            candleName = name;
            waxType = type;
            candleSize = size;
            availableStock = stock;
            reorderLevel = reorderQty;           
            usedStock = 0;

            if (candleSize == CandleSize.XL) { price = 49.99; }
            else if (candleSize == CandleSize.Large) { price = 39.99; }
            else if (candleSize == CandleSize.Medium) { price = 29.99; }
            else if (candleSize == CandleSize.Small) { price = 19.99; }
            else if (candleSize == CandleSize.TeaLight) { price = 4.99; }
            else { price = 49.99; }

        }

        public double GetPrice () 
        { 
            return price; 
        }

        public double GetPrice(int purchasedQty)
        {
            return purchasedQty * price;
        }

        //Paramter as a ref type
        public double GetPrice(int purchasedQty, ref double discountedPrice)
        {
            discountedPrice = (purchasedQty * price) * 0.1;
            return purchasedQty * price;
        }

        //Using out
        public double GetAllPrices(int purchasedQty, out double discountedPrice)
        {
            discountedPrice = 0;
            discountedPrice = (purchasedQty * price) * 1.1;
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
            Console.WriteLine($"Candle : \t{candleName}\nType: \t{waxType}\nSize :\t{candleSize}\nPrice :\t{price}\nAvailable Qty: \t{availableStock}");
        }

        
    }
}
