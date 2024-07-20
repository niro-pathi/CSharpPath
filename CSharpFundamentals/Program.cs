// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Heavenly Scent's Online Shop");

Console.WriteLine("Enter the candle type you need:");

//The following will accept the type of the candle
string candleType = Console.ReadLine();

/*
    Here are some tests around working with valid identifiers & primitive types in C#
    Working with members of primitive types
    We can write here as much as we want, this is all comment    
*/

Console.WriteLine("Enter number of " + candleType.ToUpper() + " candles you need:");
var numberOfCandles = int.Parse(Console.ReadLine());

const double candlePrice = 49.99;

double totalPrice = numberOfCandles * candlePrice;

Console.WriteLine( "Total price for candles will be $" + totalPrice.ToString());

/*
 * Working with DateTime
 * Introducing converting between types and implicit typing
 */

var deliveryDate = DateTime.Now;
deliveryDate = deliveryDate.AddDays(3);

Console.WriteLine("Your order will be delivered on:" + deliveryDate.ToLongDateString());


