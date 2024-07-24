// See https://aka.ms/new-console-template for more information
/*
 * Working with Arrays
 */

using CSharpFundamentals_L07.Candle;

string[] customerAddress = new string[4];

// Capture customer address
for (int i = 0; i < customerAddress.Length; i++)
{
    Console.WriteLine($"Enter Customer Address line {i+1}");
    customerAddress[i] = Console.ReadLine();
}

//Display customer address
for (int i = 0; i < customerAddress.Length; i++)
{
    Console.WriteLine($"Customer Address : {customerAddress[i]}");
}

//Working array of objects

Candle vanillaCaramel = new Candle("Vanilla Caramel", "Soy Wax", CandleSize.Medium);
Candle roseVictorian = new Candle("Rose Victorian", "Soy Wax", CandleSize.TeaLight);
Candle sandalwood = new Candle("Sandalwood", "Soy Wax", CandleSize.XL);
Candle lotus = new Candle("Lotus", "Soy Wax", CandleSize.XL);

Candle[] candles = new Candle[4];
candles[0] = vanillaCaramel;
candles[1] = roseVictorian;
candles[2] = sandalwood;
candles[3] = lotus;

Array.Sort(candles);

foreach(Candle c in candles)
{
    c.DisplayProdcut();
    Console.WriteLine($"Price : {c.GetPrice()}");

}