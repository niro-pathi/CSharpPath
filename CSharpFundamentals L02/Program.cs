// See https://aka.ms/new-console-template for more information

/*
   This project covers the following C3 fundamentals
    - Working with boolian types, relational operators and logical operators
    - Making decisions with if statements
    - Using Switch statement
    - Adding iterations
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


// Making decisions with if statements

Console.WriteLine("Enter the quantity you want to order : ");
int orderQty = int.Parse(Console.ReadLine());

if (orderQty < 2)
{
    Console.WriteLine("Requested quantity is less than minimum order quantity");  
}
else if (orderQty > 18)
{
    Console.WriteLine("Not enough stock");
    Console.WriteLine("Sending an email to the shop");
}
else
{
    Console.WriteLine("Great, you can continue with your order!");
}

// Using Switch statement
Console.WriteLine("Enter the quantity you want to order : ");
int qtyOrdered = int.Parse(Console.ReadLine());

switch (qtyOrdered)
{
    case < 2:
        Console.WriteLine("Requested quantity is less than minimum order quantity");
        break;
    case > 50:
        Console.WriteLine("Sorry, quantity is over the maximum order quantity");
        break;
      default:
        Console.WriteLine("Great, you can continue with your order!");
        break;
}

// Adding iterations
// Using while loop

Console.WriteLine("Enter the quantity you want to order : ");
int orderedQty = int.Parse(Console.ReadLine());

while (orderedQty < 2 || orderedQty > 50)
{
    switch (orderedQty)
    {
        case < 2:
            Console.WriteLine("Requested quantity is less than minimum order quantity");
            break;
        case > 50:
            Console.WriteLine("Sorry, quantity is over the maximum order quantity");
            break;
        default:
            break;
    }
    Console.WriteLine("Please enter the correct quantity you want to order : ");
    orderedQty = int.Parse(Console.ReadLine());
}

Console.WriteLine("Great, you can continue with your order!");

// Using Do While loop

orderedQty = 0;

do
{
    Console.WriteLine("Please enter the correct quantity you want to order : ");
    orderedQty = int.Parse(Console.ReadLine());

    switch (orderedQty)
    {
        case < 2:
            Console.WriteLine("Requested quantity is less than minimum order quantity, enter correct value");
            break;
        case > 50:
            Console.WriteLine("Sorry, quantity is over the maximum order quantity, enter correct value");
            break;
        default:
            Console.WriteLine("Great, you can continue with your order!");
            break;
    }

} while (orderedQty < 2 || orderedQty > 50);

Console.WriteLine("Great, you have ordered " + orderedQty + " candles.");

int max = 10;

// for loop
for (int i = 0; i < max; i++)
{
    if (i == 15)
    {
        Console.WriteLine("Candle code ! " + i + " was found!");
        continue;
        //break;
    }
    Console.WriteLine(i);
}
