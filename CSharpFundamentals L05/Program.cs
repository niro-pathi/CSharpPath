// See https://aka.ms/new-console-template for more information
using CSharpFundamentals_L05;

/* Understanding Classes
   Using Objects
   Working with several objects
*/

Console.WriteLine("Creating a new candle");

Candle sandalwood= new Candle("Sandalwood","Soy Wax","XL");

sandalwood.DisplayProdcut();
Console.WriteLine($"Price : {sandalwood.GetPrice()}");

Console.WriteLine("Creating a new candle");

Candle vanillacaramel = new ("Vanila Caramel", "Soy Wax", "XL");
vanillacaramel.price = 35.00;
vanillacaramel.DisplayProdcut();
Console.WriteLine($"Price : {vanillacaramel.GetPrice()}");