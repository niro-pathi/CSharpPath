// See https://aka.ms/new-console-template for more information
/*
 * Working with methods
 *  - Creating and using methods
 *  - Adding Helper class (refactoring and reorganizing the code)
 *  - Method overloading
 */

using CSharpFundamentals_L03;

Console.WriteLine("Enter the quantity you want to order : ");
int orderQty = int.Parse(Console.ReadLine());
double totalPrice = Utilities.CalculatePrice(orderQty);
string deliveryDate = Utilities.DeliveryDate();

Console.WriteLine($"Your order price is ${totalPrice} and will be delivered on {deliveryDate} .");

//method overloading 
totalPrice = Utilities.CalculatePrice(orderQty,true);
deliveryDate = Utilities.DeliveryDate(true);
Console.WriteLine($"Your order price with express delivery is ${totalPrice} and will be delivered on {deliveryDate} .");