using CSharpFundamentals_L10.Products;
using CSharpFundamentals_L10.Candle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L10
{
    internal class Utilities
    {
        private static string directory = @"C:\.Net Projects\temp";
        private static string fileName = "candles.txt";

        internal static void CheckForExistingCandleFile()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            string path = $"{directory}{fileName}";

            bool existingFileFound = File.Exists(path);
            if (existingFileFound)
            {
                Console.WriteLine("An existing file with Candle data is found.");
            }
            else
            {
                //Create the airectory already
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(directory);
                Console.WriteLine("Directory is ready for saving files.");
            }
            Console.ForegroundColor = ConsoleColor.Blue;

        }

        internal static void RegisterCandle(List<Products.Candle> candles)
        {
            Console.WriteLine("Creating a candle");

            Console.WriteLine("What type of candle do you want to register?");
            Console.WriteLine("1. Extra Large\n2. Large\n3. Small\n4. Tea Light Pack\n5. Tea Light");
            Console.Write("Your selection: ");
            string candleType = Console.ReadLine();

            if (candleType != "1" && candleType != "2" && candleType != "3"
                && candleType != "4" && candleType != "5")
            {
                Console.WriteLine("Invalid selection!");
                return;
            }

            Console.Write("Enter the candle name: ");
            string candleName = Console.ReadLine();

            Console.Write("Enter the wax type: ");
            string waxType = Console.ReadLine();

            Console.Write("Enter the availableStock:");
            int availableStock = int.Parse(Console.ReadLine());

            Console.Write("Enter the expiry date: ");
            DateTime expiryDate = DateTime.Parse(Console.ReadLine());//ex. 2/16/2008

            Products.Candle candle = null;

            
            switch (candleType)
            {
                case "1":
                    candle = new ExtraLarge(candleName, waxType, availableStock, expiryDate);
                    break;
                case "2":
                    candle = new Large(candleName, waxType, availableStock, expiryDate);
                    break;
                case "3":
                    candle = new Small(candleName, waxType, availableStock, expiryDate);
                    break;
                case "4":
                    candle = new TeaCandlePack(candleName, waxType, availableStock, expiryDate);
                    break;
                case "5":
                    candle = new TeaCandle(candleName, waxType, availableStock, expiryDate);
                    break;
            }

            candles.Add(candle);

            Console.WriteLine("Candle created!\n\n");
        }

        internal static void ViewAllCandles(List<Products.Candle> candles)
        {
            for (int i = 0; i < candles.Count; i++)
            {
                candles[i].DisplayProdcut();
            }
        }

        internal static void SaveCandles(List<Products.Candle> candles)
        {
            //First, we are going to convert employee data to a string
            //Alternatively, we could again use JSON.NET and store them as JSON

            string path = $"{directory}{fileName}";
            StringBuilder sb = new StringBuilder();

            foreach (Products.Candle candle in candles)
            {
                string type = GetCandleType(candle);

                sb.Append($"candleName:{candle.CandleName};");
                sb.Append($"waxType:{candle.WaxType};");
                sb.Append($"availableStock:{candle.AvailableStock};");
                sb.Append($"expiryDate:{candle.ExpiryDate.ToShortDateString()};");
                sb.Append($"type:{type};");
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved candle successfully");
            Console.ResetColor();
        }

        private static string GetCandleType(Products.Candle candle)
        {
            if (candle is ExtraLarge)
                return "1";
            else if (candle is Large)
                return "2";
            else if (candle is Small)
                return "3";
            else if (candle is TeaCandlePack)
                return "4";
            else if (candle is TeaCandle)
                return "5";
            return "0";
        }

        internal static void LoadCandles(List<Products.Candle> candles)
        {
            Console.WriteLine("Functionality under development.");
        }
    }
}
