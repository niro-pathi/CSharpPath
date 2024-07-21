// See https://aka.ms/new-console-template for more information
/*
 * Working with methods
 *  - Creating and using methods
 */

/*
 * Creating and using methods
 *  - creating a method
 *  - adding parameters
 *  - returning a value
 *  - invoking a method
 */

using System.Net.NetworkInformation;

Console.WriteLine("Enter the quantity you want to order : ");
int orderQty = int.Parse(Console.ReadLine());
double totalPrice = CalculatePrice(orderQty);
string deliveryDate = DeliveryDate();

Console.WriteLine($"Your order price is ${totalPrice} and will be delivered on {deliveryDate}");

static double CalculatePrice (int qty)
{
    double unitPrice = 49.99;

    return qty * unitPrice;
}

static string DeliveryDate() 
{  
    DateTime deliveryDate = DateTime.Now;
    return deliveryDate.ToLongDateString(); 
}
