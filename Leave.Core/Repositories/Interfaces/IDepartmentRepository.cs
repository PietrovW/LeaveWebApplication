using Leave.Core.Domain.Entitys;
using Leave.Core.Repositories.Base;

namespace Leave.Core.Repositories.Interfaces
{
    public interface IDepartmentRepository : IRepository<DepartmentEntity>
    {
       // Task<Tuple<ReturnCode, IEnumerable<DepartmentEntity>>> FindAllAsync<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}
