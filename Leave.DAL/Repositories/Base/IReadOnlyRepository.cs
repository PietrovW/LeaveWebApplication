using Leave.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories.Base
{
    public interface IReadOnlyRepository<T> : IDisposable where T : TEntity
    {
        Task<T> FindByIDAsync(Guid id);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> AllAsync();
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
    }
}
