using BankLocker.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankLocker.Repsitory
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected BankLockerContext context { get; set; }

        public Repository(BankLockerContext repositoryContext)
        {
            this.context = repositoryContext;
        }

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression)
        {
            return await this.context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
