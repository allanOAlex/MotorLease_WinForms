using Microsoft.EntityFrameworkCore;
using MotorLease.Data.Context;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MotorLease.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DBContext context;
        internal DbSet<T> dbSet;

        public BaseRepository(DBContext Context)
        {
            context = Context;
            dbSet = context.Set<T>();
        }

        public T Create(T entity)
        {
            context.Set<T>().Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}
