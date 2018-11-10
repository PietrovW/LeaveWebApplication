using Leave.Core.Entitys.Base;

namespace Leave.Core.Repositories.Base
{
    public interface IRepository<T> : IReadOnlyRepository<T> , IWriteOnlyRepositoryy<T> where T : TEntity
    {
      
    }
}
