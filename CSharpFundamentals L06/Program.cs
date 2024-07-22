// See https://aka.ms/new-console-template for more information
/*
 * Working with value type and referance type
 * Passing parameters by value and ref
 * Using out
 */

// Value type

using CSharpFundamentals_L05;

int a = 10;
int aCopy = a;

Console.WriteLine($"Value a : {a} value aCopy : {aCopy}");

aCopy = 200;
Console.WriteLine($"Value a : {a} value aCopy : {aCopy}");

// Referance type
Candle sandalwood = new Candle("Sandalwood", "Soy Wax", "XL");


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


