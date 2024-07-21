// See https://aka.ms/new-console-template for more information
/*
 * Working with methods
 *  - Creating and using methods
 *  - Adding Helper class (refactoring and reorganizing the code)
 *  - Method overloading
 *  - Optional parameters and named arguments
 *  - Expression bodied members
 */

using CSharpFundamentals_L03;

// Calling method with optional parameter

Console.WriteLine("Enter the quantity you want to order : ");
int orderQty = int.Parse(Console.ReadLine());
double totalPrice = Utilities.CalculatePriceWithOptional(orderQty);
string deliveryDate = Utilities.DeliveryDateExpressionBodied();

Console.WriteLine($"Your order price is ${totalPrice} and will be delivered on {deliveryDate} .");

Console.WriteLine("Enter the quantity you want to order : ");
double discountedPrice = 35.00;
orderQty = int.Parse(Console.ReadLine());
totalPrice = Utilities.CalculatePriceWithOptional(orderQty,discountedPrice);
deliveryDate = Utilities.DeliveryDateExpressionBodied();

Console.WriteLine($"Your discounted order price is ${totalPrice} and will be delivered on {deliveryDate} .");

//method overloading 
totalPrice = Utilities.CalculatePrice(orderQty,true);
deliveryDate = Utilities.DeliveryDate(true);
Console.WriteLine($"Your order price with express delivery is ${totalPrice} and will be delivered on {deliveryDate} .");