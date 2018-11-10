using Leave.Core.Entitys.Base;
using Leave.DAL.Models.Base;
using System;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories.Base
{
    public interface IWriteOnlyRepositoryy<T> : IDisposable where T : TEntity
    {
        Task<Tuple<ReturnCode,T>> AddAsync(T entity);
        Task<ReturnCode> UpdateAsync(T entity);
        Task<ReturnCode> RemoveAsync(int id);
    }
}
