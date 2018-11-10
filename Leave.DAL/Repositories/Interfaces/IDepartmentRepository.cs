using Leave.Core.Entitys;
using Leave.DAL.Repositories.Base;

namespace Leave.DAL.Repositories.Interfaces
{
    public interface IDepartmentRepository : IRepository<DepartmentEntity>
    {
       // Task<Tuple<ReturnCode, IEnumerable<DepartmentEntity>>> FindAllAsync<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}
