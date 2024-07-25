// See https://aka.ms/new-console-template for more information
/*
 * Working with Arrays
 * Working array of objects
 * Working with collections
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

foreach(Candle c in candles)
{
    c.DisplayProdcut();
    Console.WriteLine($"Price : {c.GetPrice()}");

}

//working with collection
Console.WriteLine("__________________________________________________");

Console.WriteLine("Working with collection");

List<string> address = new List<string>();

// Capture customer address
for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"Enter Customer Address line {i}");
    address.Add(Console.ReadLine());
}

// Display customer address
for (int i = 0; i < address.Count; i++)
{
    Console.WriteLine($"Customer Address {address[i]} ");
}

//Working array of objects

Console.WriteLine("");

Candle lime = new Candle("Lime", "Soy Wax", CandleSize.Medium);
Candle sugerSpice = new Candle("Suger Spice", "Soy Wax", CandleSize.TeaLight);
Candle beeHoney = new Candle("Bee Honey", "Soy Wax", CandleSize.XL);

List<Candle> candles1 = new List<Candle>();
candles1.Add(lime);
candles1.Insert(0, sugerSpice);
candles1.Add(beeHoney);

foreach (Candle c in candles1)
{
    c.DisplayProdcut();
    Console.WriteLine($"Price : {c.GetPrice()}");
}