using CSharpFundamentals_L10.Candle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L10.Products
{
    internal class Candle: ICandle
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

        private ProductReview productReview;

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

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            private set { expiryDate = value; }
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
        public ProductReview ProductReview
        {
            get { return productReview; }
            set
            {
                productReview = value;
            }
        }

        public Candle(string candleName, string candleType) : this(candleName, candleType, 10, DateTime.Today.AddDays(180))
        {

        }

        public Candle(string candleName, string candleType, int availableStock,DateTime expiryDate)
        {
            CandleName = candleName;
            WaxType = candleType;
            AvailableStock = availableStock;
            ReorderLevel = reorderQty;
            ExpiryDate = expiryDate;
            CandleWeight = 100;
            Price = 25;
            UsedStock = 0;
        }

        public Candle(string candleName, string candleType, int availableStock,DateTime expiryDate, string productReview, int numberOfStars)
        {
            CandleName = candleName;
            WaxType = candleType;
            AvailableStock = availableStock;
            ExpiryDate = expiryDate;
            Price = 25;
            CandleWeight = 100;
            ReorderLevel = reorderQty;
            UsedStock = 0;
            ProductReview = new ProductReview(productReview, numberOfStars);
        }

        public double GetPrice()
        {
            return Price * gstTax;
        }

        public double GetPrice(int purchasedQty)
        {
            return (purchasedQty * Price) * gstTax;
        }
        public double GetAllPrices(int purchasedQty, out double discountedPrice)
        {
            discountedPrice = (purchasedQty * Price) * gstTax * 1.1;
            return (purchasedQty * Price) * gstTax;
        }
        public double SellProduct(int purchasedQty)
        {
            UsedStock += purchasedQty;
            AvailableStock -= purchasedQty;

            Console.WriteLine($"{purchasedQty} {CandleName} candles have been sold and current stock is {AvailableStock}");

            return (purchasedQty * Price) * gstTax * 1.1; ;
        }

        public void DisplayProdcut()
        {
            Console.WriteLine($"Candle : \t{CandleName}\nType: \t{WaxType}\nWeight :\t{CandleWeight}g\nPrice :\t{GetPrice()}\nAvailable Qty: \t{AvailableStock}\nExpiry Date: \t{ExpiryDate.ToShortDateString()}\n");

        }

        public virtual void CheckDiscount()
        {
            Console.WriteLine("All products get standard 10% discount");

        }

        public void AddProductReview()
        {
            throw new NotImplementedException();
        }
    }
}
