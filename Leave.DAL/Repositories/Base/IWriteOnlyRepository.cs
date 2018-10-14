using Leave.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories.Base
{
    public interface IWriteOnlyRepositoryy<T> : IDisposable where T : TEntity
    {
        Task<ResultCode> AddAsync(T entity);
        Task<ResultCode> UpdateAsync(T entity);
        Task<ResultCode> RemoveAsync(Guid id);
    }
}
