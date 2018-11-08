using Leave.DAL.Context.Base;
using Leave.Core.Domain.Entitys;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;


namespace Leave.DAL.Repositories
{

    public class FurloughRepository : GenericRepository<FurloughEntity>, IFurloughRepository
    {
        public FurloughRepository(IDbContextBase dbContext, string tableName) : base(dbContext, tableName)
        {
        }

        internal override dynamic Mapping(FurloughEntity item)
        {
            return new
            {
                item.Id,
                item.Name,
                item.Inserted,
                item.Updated,
                item.FVer
            };
        }
    }
}
