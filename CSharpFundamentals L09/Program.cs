// See https://aka.ms/new-console-template for more information
/*
 * Adding Encapsulation
 * Bringing Inheritance
 * Using inheritance as Is-A Relation and Has-A Composition
 * Using Polymorphism
 * Using Interfaces
 */

using CSharpFundamentals_L09.Candle;

ICandle vanillaXL = new ExtraLarge("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax",10);
ICandle vanillaTea = new TeaLight("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax", 10);
ICandle vanillaTeaPack = new TeaLightPack("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax", 10);
//Is-A Relation
ICandle lotusTeaPack = new TeaLightPack("Lotus Scented Soy Wax Candle", "Soy Wax", 10);
//Composition Has-A
ICandle roseVictorian = new Candle("Rose Victorian Scented Soy Wax Candle", "Soy Wax", 10,"Great product",5);

List<ICandle> candles = new List<ICandle>();
candles.Add(vanillaXL);
candles.Add(vanillaTea);
candles.Add(vanillaTeaPack);
candles.Add(lotusTeaPack);
candles.Add(roseVictorian);

foreach (Candle candle in candles)
{
    candle.DisplayProdcut();
    candle.CheckDiscount();
    Console.WriteLine("________________________________________");
}