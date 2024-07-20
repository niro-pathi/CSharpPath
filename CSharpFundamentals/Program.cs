// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Heavenly Scent's Online Shop");

Console.WriteLine("Enter the candle type you need:");

//The following will accept the type of the candle
string candleType = Console.ReadLine();

/*
    Here are some tests around working with valid identifiers in C#
    We can write here as much as we want, this is all comment
*/

Console.WriteLine("Enter number of candles you need:");
var numberOfCandles = int.Parse(Console.ReadLine());

const double candlePrice = 49.99;

double totalPrice = numberOfCandles * candlePrice;

Console.WriteLine(totalPrice);

