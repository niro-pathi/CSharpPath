// See https://aka.ms/new-console-template for more information
/*
 * Working with value type and referance type
 * Passing parameters by value and ref
 * Using out
 * Strings are referance type	
 * Using String builder
 * Using enumerations
 * Usig struct
 */

// Value type

using CSharpFundamentals_L05;
using CSharpFundamentals_L06;
using Microsoft.VisualBasic;
using System.Text;

int a = 10;
int aCopy = a;

Console.WriteLine($"Value a : {a} value aCopy : {aCopy}");

aCopy = 200;
Console.WriteLine($"Value a : {a} value aCopy : {aCopy}");

// Referance type
// Using enumerations
Candle sandalwood = new Candle("Sandalwood", "Soy Wax", CandleSize.XL);


Candle lotus = sandalwood;
lotus.candleName = "Lotus";

sandalwood.DisplayProdcut();
lotus.DisplayProdcut();

//  Passing parameters by value and ref
double discountedPrice = 0;
int purchasedQty = 5;

Console.WriteLine($"Full price ${lotus.GetPrice(purchasedQty, ref discountedPrice)} Discounted price ${discountedPrice}");

//Using Out
double finalPrice;
Console.WriteLine($"Full price ${lotus.GetAllPrices(purchasedQty, out finalPrice)} Discounted price ${finalPrice}");
Console.WriteLine();

// Strings are referance type

string candleName = "Sandalwood";
string otherCandleName = candleName;


candleName += " Scented Candle.";
string upperCaseCandleName = candleName.ToUpper();

Console.WriteLine($"Candle Name {candleName} Other name {otherCandleName}");
Console.WriteLine($"Candle Uppercase Name {upperCaseCandleName}");
Console.WriteLine();

//Using String Builder
StringBuilder review = new StringBuilder();
Console.WriteLine("Add product review");

review.Append(Console.ReadLine());
review.AppendLine(Console.ReadLine());
review.AppendLine(Console.ReadLine());

string finalReview = review.ToString();

Console.WriteLine($"Product Review {finalReview}");

// Using enumerations
Candle vanillaCaramel = new Candle("Vanilla Caramel", "Soy Wax", CandleSize.Medium);
vanillaCaramel.DisplayProdcut();
Console.WriteLine();
Candle roseVictorian = new Candle("Rose Victorian", "Soy Wax", CandleSize.TeaLight);
roseVictorian.DisplayProdcut();

Console.WriteLine();

// Using struct
ProductReview productReview;
productReview.review = "Great product";
productReview.numberOfStars = 4;
productReview.DisplayRating();
