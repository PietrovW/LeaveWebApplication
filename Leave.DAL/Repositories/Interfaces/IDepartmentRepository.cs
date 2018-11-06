using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Leave.DAL.Entitys;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Base;

namespace Leave.DAL.Repositories.Interfaces
{
    public interface IDepartmentRepository : IRepository<DepartmentEntity>
    {
       // Task<Tuple<ReturnCode, IEnumerable<DepartmentEntity>>> FindAllAsync<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}
