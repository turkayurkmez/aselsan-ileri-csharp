using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T> where T : class
    {
        int Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);

        IEnumerable<T> GetAll();

  

  
    
    }

    public interface IProductRepository : IRepository<object>
    {
        IEnumerable<object> GetProductsByCategory(int categoryId);
        IEnumerable<object> SearchByName(string name);


    }

    public class ProductRepository : IProductRepository
    {
        public int Create(object entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(object entity)
        {
            throw new NotImplementedException();
        }
    }


}
