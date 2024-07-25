// See https://aka.ms/new-console-template for more information
/*
 * Adding Encapsulation
 * Bringing Inheritance
 * Using inheritance as Is-A Relation and Has-A Composition
 * Using Polymorphism
 */

using CSharpFundamentals_L09.Candle;

Candle candle = new Candle("Vanilla Caramel", "Soy Wax");
candle.DisplayProdcut();
candle.CheckDiscount();

Console.WriteLine("________________________________________");

ExtraLarge vanillaXL = new ExtraLarge("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax",10);
vanillaXL.DisplayProdcut();
vanillaXL.CheckDiscount();
Console.WriteLine("________________________________________");
TeaLight vanillaTea = new TeaLight("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax", 10);
vanillaTea.DisplayProdcut();
vanillaTea.CheckDiscount();
Console.WriteLine("________________________________________");
TeaLightPack vanillaTeaPack = new TeaLightPack("Vanilla Caramel Scented Soy Wax Candle", "Soy Wax", 10);
vanillaTeaPack.AddCandleCaringPack();
vanillaTeaPack.DisplayProdcut();
vanillaTeaPack.CheckDiscount();
Console.WriteLine("________________________________________");

//Is-A Relation
TeaLight lotusTeaPack = new TeaLightPack("Lotus Scented Soy Wax Candle", "Soy Wax", 10);
lotusTeaPack.DisplayProdcut();
lotusTeaPack.CheckDiscount();
Console.WriteLine("________________________________________");

//Composition Has-A
Candle roseVictorian = new Candle("Rose Victorian Scented Soy Wax Candle", "Soy Wax", 10,"Great product",5);
roseVictorian.DisplayProdcut();
roseVictorian.CheckDiscount();
