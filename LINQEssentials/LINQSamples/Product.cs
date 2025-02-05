using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
    public class Product
    {
        public int Id { get; set; }


        public string Name { get; set; }

        //public Product()
        //{
        //    Name = "Name Placeholder";
        //}
        public string Description { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }

        public Category Category { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductService
    {
        private readonly List<Product> _products;
        private readonly List<Category> _categories;
        public ProductService()
        {
            _categories = new List<Category>() {
                new() { Id=1, Name="Üst Giyim" },
                new() { Id=2, Name="Alt Giyim" },
                new() { Id=4, Name="Aksesuar" }
           };

            _products = new List<Product>() {
                new() { Id=1, Name="T-Shirt", Description="Beyaz T-Shirt", Color="Beyaz", Price=50, Rating=4.5, Category=_categories[0] },
                new() { Id=2, Name="Jean", Description="Mavi Jean", Color="Mavi", Price=150, Rating=4.0, Category=_categories[1] },
                new() { Id=3, Name="Çanta", Description="Deri Çanta", Color="Kahverengi", Price=250, Rating=4.5, Category=_categories[2] },
                new() { Id=4, Name="Kazak", Description="Boğazlı Kazak", Color="Siyah", Price=750, Rating=4.0, Category=_categories[0] },
                new() { Id=5, Name="Kanvas Pantolon", Description="Hebele", Color="Yeşil", Price=850, Rating=4.5, Category=_categories[1] },
                new() { Id=6, Name="Saat", Description="Deri Kayış", Color="Kahverengi", Price=950, Rating=4.0, Category=_categories[2] },
                new() { Id=7, Name="Gömlek", Description="Kareli Gömlek", Color="Kırmızı", Price=350, Rating=4.5, Category=_categories[0] },
                new() { Id=8, Name="Kemer", Description="Deri Kemer", Color="Kahverengi", Price=150, Rating=4.0, Category=_categories[2] },
                new() { Id=9, Name="Ceket", Description="Kadife Ceket", Color="Siyah", Price=950, Rating=4.5, Category=_categories[0] },
                new() { Id=10, Name="Eşarp", Description="İpek Eşarp", Color="Mavi", Price=450, Rating=4.0, Category=_categories[2] },
                new() { Id=11, Name="Kaban", Description="Kışlık Kaban", Color="Siyah", Price=1250, Rating=4.5, Category=_categories[0] }




            };
        }

        public List<Product> GetProducts() => _products;
    }
}
