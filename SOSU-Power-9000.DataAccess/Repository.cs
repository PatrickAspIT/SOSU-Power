using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSU_Power_9000.DataAccess
{
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

        public void Delete(T entity)
        {
            dataContext.Remove(entity);
            dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = GetBy(id);
            Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return dataContext.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return dataContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            dataContext.Update(entity);
            dataContext.SaveChanges();
        }
    }
}
