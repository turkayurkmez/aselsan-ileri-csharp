// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Product newProduct = new Product();
Console.WriteLine("Ürün fiyatını girin: ");
decimal fiyat = Convert.ToDecimal(Console.ReadLine());
//if (fiyat<0)
//{
//    throw new ArgumentException("fiyat negatif olamaz");
//}

newProduct.SetPrice(fiyat);
newProduct.Name = "Kalem";

