using Leave.DAL.Context.Base;
using Leave.Core.Domain.Entitys;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;

namespace Leave.DAL.Repositories
{
    public class DepartmentRepository : GenericRepository<DepartmentEntity>, IDepartmentRepository
    {
        public DepartmentRepository(IDbContextBase dbContext, string tableName) : base(dbContext, tableName)
        {
        }
    }
}
