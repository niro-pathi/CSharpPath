// See https://aka.ms/new-console-template for more information
/*
 * Adding Encapsulation
 */

using CSharpFundamentals_L09.Candle;

Candle candle = new Candle("Vanilla Caramel", "Soy Wax", CandleSize.Medium);
candle.DisplayProdcut();

Console.WriteLine("");

candle.CandleName = "Vanilla Caramel Scented Soy Wax Candle";
candle.DisplayProdcut();
