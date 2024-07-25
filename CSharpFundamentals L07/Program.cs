// See https://aka.ms/new-console-template for more information

/*
 * Working with Namespaces
 * Using static
 */

using CSharpFundamentals_L07.Accounting;
using CSharpFundamentals_L07.Candle;

#region Creating candle objects
Candle vanillaCaramel = new Candle("Vanilla Caramel", "Soy Wax", CandleSize.Medium);
vanillaCaramel.DisplayProdcut();
Console.WriteLine($"Price : {vanillaCaramel.GetPrice()}");
Console.WriteLine();

Candle.gstTax = 1.2;

Candle roseVictorian = new Candle("Rose Victorian", "Soy Wax", CandleSize.TeaLight);
roseVictorian.DisplayProdcut();
Console.WriteLine($"Price : {roseVictorian.GetPrice()}");
#endregion

#region Creating Product review
Console.WriteLine();

ProductReview productReview;
productReview.review = "Great product";
productReview.numberOfStars = 4;
productReview.DisplayRating();
#endregion

#region Creating Customer object
Customer customer = new Customer();
#endregion