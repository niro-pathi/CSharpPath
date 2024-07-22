// See https://aka.ms/new-console-template for more information

/*
 * Working with Strings
 */

// Manipulating strings
// Concatenating strings
// Using string interpolation
// using escape characters


using CSharpFundamentals_L04;

string firstName, lastName;

Console.WriteLine(Utilities.WelcomeMessage());

Console.WriteLine("Please enter your first name :");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your first name :");
lastName = Console.ReadLine();

Console.WriteLine(Utilities.WelcomeMessage(firstName, lastName));
