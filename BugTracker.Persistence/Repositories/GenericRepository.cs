using BugTracker.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BugTrackerDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(BugTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }



        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            // includes parameter - configure the lazy loading. 
            // if we have a hotel, include the country also for example
            IQueryable<T> query = _dbSet;
            if (includes != null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression); // can be a lambda expression as a parameter
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified; // notify ef core change tracker
            await _dbContext.SaveChangesAsync();
        }

        // public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null,
        //Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        // {
        //     IQueryable<T> query = _dbSet;

        //     if (expression != null)
        //     {
        //         query = query.Where(expression);
        //     }
        //     attach extra
        //     if (includes != null)
        //     {
        //         foreach (var includeProperty in includes)
        //         {
        //             query = query.Include(includeProperty);
        //         }
        //     }
        //     order
        //     if (orderBy != null)
        //     {
        //         query = orderBy(query);
        //     }

        //     return await query.AsNoTracking().ToListAsync();
        // }


        //public async Task<bool> IsUniqueAsync(T entity, string tProperty, string uniqueString)
        //{
        //    var entity = await _dbContext.Set<T>().FindAsync(x => x.tProperty == uniqueString);
        //}

    }
}
