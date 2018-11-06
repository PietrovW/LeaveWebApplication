using Leave.DAL.Entitys.Base;
using Leave.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories.Base
{
    public interface IReadOnlyRepository<T> : IDisposable where T : TEntity 
    {
        Task<Tuple<ReturnCode, IEnumerable<T>>> AllAsync();
        Task<Tuple<ReturnCode, IEnumerable<T>>> FindAllAsync(Expression<Func<T, bool>> predicate);
    }
}
