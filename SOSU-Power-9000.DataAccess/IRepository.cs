using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSU_Power_9000.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext dataContext;

        public Repository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Add(T entity)
        {
            dataContext.Add(entity);
            dataContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dataContext.Update(entity);
            dataContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dataContext.Remove(entity);
            dataContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dataContext.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return dataContext.Set<T>().Find(id);
        }
    }
}
