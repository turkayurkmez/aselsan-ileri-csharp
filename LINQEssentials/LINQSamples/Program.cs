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