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

        public int CandleWeight
        {
            get { return candleWeight; }
            protected set { candleWeight = value; }
        }

        public double Price
        {
            get { return price; }
            protected set { price = value; }
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

        public Candle(string firstName, string candleType) : this(firstName, candleType, 10)
        {

        }

        public Candle(string firstName, string candleType, int availableStock)
        {
            CandleName = firstName;
            WaxType = candleType;
            AvailableStock = availableStock;
            ReorderLevel = reorderQty;
            UsedStock = 0;
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
            Console.WriteLine($"Candle : \t{CandleName}\nType: \t{WaxType}\nWeight :\t{CandleWeight}g\nPrice :\t{Price}\nAvailable Qty: \t{AvailableStock}");
        }


    }
}
