// See https://aka.ms/new-console-template for more information
/*
 * Adding Encapsulation
 * Bringing Inheritance
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