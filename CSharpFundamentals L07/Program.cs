// See https://aka.ms/new-console-template for more information

/*
 * Working with Namespaces
 */

using CSharpFundamentals_L07.Accounting;
using CSharpFundamentals_L07.Candle;

Candle vanillaCaramel = new Candle("Vanilla Caramel", "Soy Wax", CandleSize.Medium);
vanillaCaramel.DisplayProdcut();
Console.WriteLine();
Candle roseVictorian = new Candle("Rose Victorian", "Soy Wax", CandleSize.TeaLight);
roseVictorian.DisplayProdcut();

Console.WriteLine();

ProductReview productReview;
productReview.review = "Great product";
productReview.numberOfStars = 4;
productReview.DisplayRating();

Customer customer = new Customer();