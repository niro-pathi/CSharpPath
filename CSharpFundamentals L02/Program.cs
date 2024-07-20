// See https://aka.ms/new-console-template for more information

/*
   This project covers the following C3 fundamentals
    - Working with boolian types, relational operators and logical operators
    - Making decisions with if statements
 */

// Working with boolian types, relational operators 
int availableStock = 23;
bool a = availableStock == 23;

Console.WriteLine("Available Candle Stock is 23 " + a);

bool b = availableStock > 23;
Console.WriteLine("Available Candle stock is greater than 23 " + b);

// Working with logical operators
int jar = 16;
int package = 64;

bool d = (jar >= 18) && (package <= 65);
Console.WriteLine("Available Jar stock is greater than 18 AND Package stock is less than 65: " + d);

bool e = (jar >= 18) || (package <= 65);
Console.WriteLine("Available Jar stock is greater than 18 OR Package stock is less than 65: " + e);
