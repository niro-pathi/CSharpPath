// See https://aka.ms/new-console-template for more information

/*
 * Working with Strings
 * Manipulating strings
 * Concatenating strings
 * Using string interpolation
 * Using escape characters
 * Comparing strings
 * Parsing Strings
*/


using CSharpFundamentals_L04;

string firstName, lastName;

Console.WriteLine(Utilities.WelcomeMessage());

Console.WriteLine("Please enter your first name :");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your first name :");
lastName = Console.ReadLine();

Console.WriteLine(Utilities.WelcomeMessage(firstName, lastName));

Console.WriteLine("Please enter your delivery location :");
string deliveryLocation = Console.ReadLine();
Console.WriteLine($"Free shipping for {deliveryLocation}: {Utilities.IsEligibleForFreeShipping(deliveryLocation)}");

Console.WriteLine("Please enter your delivery location postcode :");
string deliveryPostcode = Console.ReadLine();
Console.WriteLine($"Your postcode is {Utilities.ValidatePostCode(deliveryPostcode)} :");