using Leave.DAL.Context.Base;
using Leave.Core.Domain.Entitys;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;


namespace Leave.DAL.Repositories
{

    public class EmployeRepository : GenericRepository<EmployeEntity>, IEmployeRepository
    {
        public EmployeRepository(IDbContextBase dbContext, string tableName) : base(dbContext, tableName)
        {

        }

        internal override dynamic Mapping(EmployeEntity item)
        {
            return new
            {
                item.Id,
                item.Name,
                item.Surname,
                item.FVer,
                item.Inserted,
                item.Updated
            };
        }

    }
}
