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

        const int reorderQty = 5;

        public Candle(string name, string type, string size) : this(name,type,size,10)
        {
     
        }

        public Candle(string name, string type, string size, int stock)
        {
            candleName = name;
            waxType = type;
            candleSize = size;
            availableStock = stock;
            reorderLevel = reorderQty;
            price = 49.99;
            usedStock = 0;
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

        public double SellProduct(int purchasedQty)
        {
            usedStock += purchasedQty;
            availableStock -= purchasedQty;

            Console.WriteLine($"{purchasedQty} {candleName} candles have been sold and current stock is {availableStock}");

            return purchasedQty * price;
        }
       
        public void DisplayProdcut()
        {
            Console.WriteLine($"Candle : \t{candleName}\nType: \t{waxType}\nAvailable Qty: \t{availableStock}");
        }

        
    }
}
