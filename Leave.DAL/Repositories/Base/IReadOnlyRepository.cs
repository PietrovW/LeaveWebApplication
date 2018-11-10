using Leave.Core.Entitys.Base;
using Leave.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories.Base
{
    public interface IReadOnlyRepository<T> : IDisposable where T : TEntity 
    {
        Task<IEnumerable<T>> AllAsync();
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
    }
}
