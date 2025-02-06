// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/*
 *  Bir nesne, ....gelişime..... açık .......değişime.... kapalı olmalıdır.
 */

Customer customer = new Customer { Name = "Ali", CardType =new PremiumCard()};
OrderManager orderManager = new OrderManager { Customer = customer };
var totalPrice = orderManager.GetTotalPrice(1000);
Console.WriteLine(totalPrice);