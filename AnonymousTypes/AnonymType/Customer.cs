using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymType
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Info { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }

    public class  CustomerService
    {
        private List<Customer> customers = new()
        {
             new(){ Id = 1, Name = "John", City = "New York", Region = "NY", PostalCode = "10001", Country = "USA" },
                new(){ Id = 2, Name = "Smith", City = "Los Angeles", Region = "CA", PostalCode = "90001", Country = "USA" },
                new(){ Id = 3, Name = "David", City = "Roma", Region = "IL", PostalCode = "60601", Country = "Italy" }

        };

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }
    }

}
