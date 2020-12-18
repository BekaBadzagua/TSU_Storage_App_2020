using DAL.Context;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Service.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected StoreDbContext Context { get; set; }

        public RepositoryBase(StoreDbContext context)
        {
            this.Context = context;
        }


        public void Create(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public IEnumerable<T> FindAll()
        {
            return Context.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression);
        }

        public T Get(int Id)
        {
            return Context.Set<T>().Find(Id);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }
    }
}
