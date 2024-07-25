using CSharpFundamentals_L09;

namespace CSharpFundamentals_L09.Tests
{
    public class CandleTests
    {
        [Fact]
        public void SellProducts_CalculateCost_Used_and_Available_Qty()
        {
           
            // Arrange
            Candle.Candle candle = new("Rose Victorian Scented Soy Wax Candle", "Soy Wax", 10, "Great product", 5);
            int purchasedQty = 5;
            //Act
            candle.SellProduct(purchasedQty);

            //Assert
            Assert.Equal(5, candle.UsedStock);
            Assert.Equal(5, candle.AvailableStock);
        }

        [Fact]
        public void GetPrice_CalculatedPurchasedCost()
        {
            //Arrange
            Candle.Candle candle = new("Rose Victorian Scented Soy Wax Candle", "Soy Wax", 10, "Great product", 5);
            int purchasedQty = 5;
            //Act
            double salescost = candle.GetPrice(purchasedQty);

            //Assert
            Assert.Equal(137.5, salescost);

        }
    }
}