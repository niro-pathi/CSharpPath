// See https://aka.ms/new-console-template for more information
/*
 * Adding Encapsulation
 * Bringing Inheritance
 * Using inheritance as Is-A Relation and Has-A Composition
 */

using CSharpFundamentals_L09.Candle;

Candle candle = new Candle("Vanilla Caramel", "Soy Wax");
candle.DisplayProdcut();

Console.WriteLine("________________________________________");

ExtraLarge vanillaXL = new ExtraLarge("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax",10);
vanillaXL.DisplayProdcut();
Console.WriteLine("________________________________________");
TeaLight vanillaTea = new TeaLight("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax", 10);
vanillaTea.DisplayProdcut();
Console.WriteLine("________________________________________");
TeaLightPack vanillaTeaPack = new TeaLightPack("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax", 10);
vanillaTeaPack.AddCandleCaringPack();
vanillaTeaPack.DisplayProdcut();
Console.WriteLine("________________________________________");

//Is-A Relation
TeaLight lotusTeaPack = new TeaLightPack("Lotus Scented Soy Wax Candle", "Soy Wax", 10);
lotusTeaPack.DisplayProdcut();
Console.WriteLine("________________________________________");

//Composition Has-A
Candle roseVictorian = new Candle("Rose Victorian Scented Soy Wax Candle", "Soy Wax", 10,"Great product",5);
roseVictorian.DisplayProdcut();
