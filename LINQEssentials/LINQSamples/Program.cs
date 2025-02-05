// See https://aka.ms/new-console-template for more information
using LINQSamples;

Console.WriteLine("Hello, World!");
ProductService productService = new ProductService();
var products = productService.GetProducts();


/*
 * SELECT Name, Price FROM Products WHERE Price > 500
 */
var standardQuery = from product in products
                    where product.Color.Contains("Kahverengi")
                    orderby product.Price descending
                    select new { product.Name, product.Price };

show(standardQuery);

Console.WriteLine("----------------- Extension ile ----------------------");
var extensionQuery = products.Where(p => p.Color.Contains("Kahverengi"))
                             .OrderByDescending(p => p.Price)
                             .Select(p => new { p.Name, p.Price });

show(extensionQuery);
void show(IEnumerable<dynamic> standardQuery)
{
    foreach (dynamic item in standardQuery)
    {
        Console.WriteLine($"{item.Name}-------{item.Price}");
    }
}

var findingProduct = products.FirstOrDefault(p=> p.Category.Name.Contains("Üst Giyim"));
Console.WriteLine($"Bulunan ürün: {findingProduct?.Name}");

//birden fazla olmasının istenmediği durumlarda:
var findingProduct2 = products.SingleOrDefault(p => p.Id == 13);

Console.WriteLine($"{findingProduct2?.Name}");

/* Aggregate Functions */

var averagePrice = products.Average(p => p.Price);
Console.WriteLine($"Ortalama Fiyat: {averagePrice}");
var totalPrices = products.Sum(p => p.Price);
var lowRatedProductCount = products.Count(p => p.Rating < 4.5);
var maxPrice = products.Max(p => p.Price);
//max fiyatı göster:

Console.WriteLine($"En yüksek fiyat: {maxPrice}");

var maxPricedProduct = products.Find(p => p.Price == maxPrice);
Console.WriteLine($"En yüksek fiyatlı ürün: {maxPricedProduct?.Name}");
var minPriceProduct = products.MinBy(p => p.Price);


var minPrice = products.Min(p => p.Price);
Console.WriteLine("------------- Group By -------------");

var grpProducts = products.GroupBy(product => product.Color, item => new { item.Name, item.Price, item.Rating }, (color, products) =>
{
    return new { Key = color, Adet = products.Count(), EnUcuz = products.Min(x => x.Price), OrtalamaPuan = products.Average(p => p.Rating) };
});

grpProducts.ToList().ForEach(p => Console.WriteLine($"{p.Key}\t{p.Adet}\t{p.EnUcuz}\t{p.OrtalamaPuan}"));

var collection = Enumerable.Range(1, 20);

var chunked = collection.Chunk(4);
foreach (var item in chunked)
{
    Console.WriteLine(string.Join(",",item));
}
Console.WriteLine("Skip ve Take ");
var taked = collection.Skip(3).Take(5);
var anotherTake = collection.Take(^4..);
foreach (var item in anotherTake)
{
    Console.WriteLine(item);
}
