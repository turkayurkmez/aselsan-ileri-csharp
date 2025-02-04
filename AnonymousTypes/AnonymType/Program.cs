// See https://aka.ms/new-console-template for more information




using AnonymType;

Console.WriteLine("Hello, World!");

var service = new CustomerService();
var italyCustomer = from customer in service.GetCustomers()
                    where customer.Country == "Italy"
                    select new { Ad= customer.Name, Sehir= customer.City,   Ulke =customer.Country };

foreach (var item in italyCustomer)
{
    Console.WriteLine($"Ad: {item.Ad}, Sehir: {item.Sehir}, Ulke: {item.Ulke}");
}