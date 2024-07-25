
using CSharpFundamentals_L10;
using CSharpFundamentals_L10.Products;

List<Candle> candles = new List<Candle>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("*   Heavenly Scents's Online App  *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingCandleFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {candles.Count} candles(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Create a new Candle");
    Console.WriteLine("2: View all Candles");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterCandle(candles);
            break;
        case "2":
            Utilities.ViewAllCandles(candles);
            break;
        case "3":
            Utilities.SaveCandles(candles);
            break;
        case "4":
            Utilities.LoadCandles(candles);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}
while (userSelection != "9");
Console.WriteLine("Thanks for using the application");