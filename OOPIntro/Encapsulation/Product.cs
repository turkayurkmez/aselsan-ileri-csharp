using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private decimal price;
        public void SetPrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("fiyat negatif olamaz");
            }
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        public bool IsAvailable { get; init; }

         public void CheckStock()
        {
            // Stok kontrolü yapılır
            //IsAvailable = true;
        }
        public Product()
        {
            IsAvailable = true; 
        }
    }
}
