using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L09.Candle
{
    internal class Candle
    {
        private string candleName;
        private string waxType;

        private int candleWeight;
        private int availableStock;
        private int reorderLevel = 10;
        private int usedStock;

        private double price;
        private DateTime expiryDate;

        // Using enumerations
        private CandleSize candleSize;

        private static double gstTax = 1.10;

        private const int reorderQty = 5;

        public string CandleName
        {
            get { return candleName; }
            set { candleName = value; }
        }

        public string WaxType
        {
            get { return waxType; }
            set { waxType = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public int AvailableStock
        {
            get { return availableStock; }
            private set { availableStock = value; }
        }

        public int ReorderLevel
        {
            get { return reorderLevel; }
            private set { reorderLevel = value; }
        }

        public int UsedStock
        {
            get { return usedStock; }
            private set { usedStock = value; }
        }

        public CandleSize CandleSize
        {
            get { return candleSize; }
            private set { candleSize = value; }
        }

        public Candle(string firstName, string candleType, CandleSize candleSize) : this(firstName, candleType, candleSize, 10)
        {

        }

        public Candle(string firstName, string candleType, CandleSize candleSize, int availableStock)
        {
            CandleName = firstName;
            WaxType = candleType;
            CandleSize = candleSize;
            AvailableStock = availableStock;
            ReorderLevel = reorderQty;
            UsedStock = 0;

            if (candleSize == CandleSize.XL) { Price = 49.99; }
            else if (candleSize == CandleSize.Large) { Price = 39.99; }
            else if (candleSize == CandleSize.Medium) { Price = 29.99; }
            else if (candleSize == CandleSize.Small) { Price = 19.99; }
            else if (candleSize == CandleSize.TeaLight) { Price = 4.99; }
            else { Price = 49.99; }

        }

        public double GetPrice()
        {
            return Price * gstTax;
        }

        public double GetPrice(int purchasedQty)
        {
            return (purchasedQty * Price) * gstTax;
        }

        //Paramter as a ref type
        public double GetPrice(int purchasedQty, ref double discountedPrice)
        {
            discountedPrice = ((purchasedQty * Price) * gstTax) * 0.1;
            return (purchasedQty * Price) * gstTax;
        }

        //Using out
        public double GetAllPrices(int purchasedQty, out double discountedPrice)
        {
            discountedPrice = 0;
            discountedPrice = (purchasedQty * Price) * gstTax * 1.1;
            return (purchasedQty * Price) * gstTax;
        }


        public double SellProduct(int purchasedQty)

        {
            UsedStock += purchasedQty;
            AvailableStock -= purchasedQty;

            Console.WriteLine($"{purchasedQty} {CandleName} candles have been sold and current stock is {AvailableStock}");

            return purchasedQty * Price;
        }

        public void DisplayProdcut()
        {
            Console.WriteLine($"Candle : \t{CandleName}\nType: \t{WaxType}\nSize :\t{CandleSize}\nPrice :\t{Price}\nAvailable Qty: \t{AvailableStock}");
        }


    }
}
