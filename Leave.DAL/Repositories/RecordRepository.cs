using Leave.DAL.Context.Base;
using Leave.Core.Domain.Entitys;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;

namespace Leave.DAL.Repositories
{
    public class RecordRepository : GenericRepository<RecordEntity>, IRecordRepository
    {
        public RecordRepository(IDbContextBase dbContext, string tableName) : base(dbContext, tableName)
        {
        }

        internal override dynamic Mapping(RecordEntity item)
        {
            return new
            {
                item.Id,
                item.DepartmentId,
                item.EmployeId,
                item.From,
                item.To,
                item.FVer,
                item.Inserted,
                item.Updated
            };
        }
    }
}
