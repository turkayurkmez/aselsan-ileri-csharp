using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";

        private SqlHelper sqlHelper;
        public ProductService()
        {
            sqlHelper = new SqlHelper(connectionString);
        }
        public int CreateProduct(string name, decimal price)
        {
            //var sqlHelper = new SqlHelper(connectionString);
            var query = "INSERT INTO Products (ProductName, UnitPrice) VALUES (@name, @price)";
            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@price", price }
            };

            return sqlHelper.ExecuteNonQuery(query, parameters);
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, UnitPrice) VALUES (@name, @price)", connection);
            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Parameters.AddWithValue("@price", price);
            //connection.Open();
            //var result = cmd.ExecuteNonQuery();
            //connection.Close();
            //return result;
        }

        public int UpdateProduct(string name, decimal price)
        {
            //var sqlHelper = new SqlHelper(connectionString);
            var query = "UPDATE Products SET UnitPrice = @price WHERE ProductName = @name";
            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@price", price }
            };

            return sqlHelper.ExecuteNonQuery(query, parameters);
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("UPDATE Products SET UnitPrice = @price WHERE ProductName = @name", connection);
            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Parameters.AddWithValue("@price", price);
            //connection.Open();
            //var result = cmd.ExecuteNonQuery();
            //connection.Close();
            //return result;
        }
    }
}
