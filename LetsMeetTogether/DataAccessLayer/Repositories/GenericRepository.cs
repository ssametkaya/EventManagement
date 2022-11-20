using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Delete(T item)
        {
            using var context = new AppDbContext();
            context.Remove(item);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new AppDbContext();
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var context = new AppDbContext();
            return context.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            using var context = new AppDbContext();
            context.Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            using var context = new AppDbContext();
            context.Update(item);
            context.SaveChanges();
        }
    }
}
