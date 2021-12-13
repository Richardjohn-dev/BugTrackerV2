using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int id);

        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);

        //Task<IList<T>> GetAll(
        //  // define parameters
        //  Expression<Func<T, bool>> expression = null,
        //  Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //  List<string> includes = null
        //  );

        Task<IReadOnlyList<T>> GetAllAsync();
        Task<bool> ExistsAsync(int id);
        //Task<bool> IsUniqueAsync(T entity, string tProperty, string uniqueString);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}
