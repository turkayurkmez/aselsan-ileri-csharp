// Müşteri hizmetleri servisi oluşturuluyor
var service = new CustomerService();

// İtalya'daki müşterileri seçen sorgu
var italyCustomer = from customer in service.GetCustomers()
                    where customer.Country == "Italy"
                    select new { Ad = customer.Name, Sehir = customer.City, Ulke = customer.Country };

// Uzantı metodu ile İtalya'daki müşterileri filtreleme ve sıralama
var extResult = service.GetCustomers().Where(c => c.Country.Contains("Italy"))
                                      .Select(c => new { c.Name, c.City, c.Country })
                                      .OrderBy(c => c.Name);

// Sonuç sayısını konsola yazdırma
Console.WriteLine(extResult.Count());

// İtalya'daki müşterilerin bilgilerini konsola yazdırma
foreach (var item in italyCustomer)
{
    Console.WriteLine($"Ad: {item.Ad}, Sehir: {item.Sehir}, Ulke: {item.Ulke}");
}