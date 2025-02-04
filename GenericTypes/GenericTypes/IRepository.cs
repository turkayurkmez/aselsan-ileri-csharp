using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    //Repository'nin amacı:
    //Belirtilen Entity ile db işlemlerini yapmak (Insert, Update, Delete... ). 
    public interface IRepository<TEntity, TId> where TEntity : class, IEntity<TId>,new()
                                               where TId : IEquatable<TId>
    {
        //void Create(T entity);
        TEntity Get(TId id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TId id);

        IEnumerable<TEntity> GetAll();
    }

    //Amaç: Bir Entity'nin mutlaka bir Id'si olmalı ama türü farklı olabilir.
    public interface IEntity<TId>  where TId : IEquatable<TId>
    {
        TId Id { get; set; }
    }

    public class Product : IEntity<long>
    {
        public long Id { get ; set ; }
    }

    public class Category : IEntity<Guid>
    {
        public Guid Id { get; set; }
    }

    public class ProductRepository : IRepository<Product, long>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Product Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    //public class Guitar { } 
    //public class ElectricGuitar : Guitar { }

    //public class AcousticGuitar : Guitar { }

    //public class GuitarRepository : IRepository<Guitar>
    //{
    //    public void Create(Guitar entity)
    //    {
    //        Console.WriteLine("Creating Guitar");
    //    }

    //    public Guitar Get(int id)
    //    {
    //        return new ElectricGuitar();
    //    }
    //}

    public class Customer : IEntity<Guid>
    {
        public Guid Id { get; set; }
    }

    public class CustomerRepository : IRepository<Customer, Guid>
    {
        public void Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
