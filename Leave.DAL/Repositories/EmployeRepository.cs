using Leave.DAL.Context.Base;
using Leave.Core.Entitys;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;
using System;

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
                item.Email,
                item.Username,
                item.FullName,
                item.Role,
                item.Password,
                item.Salt,
                item.FVer,
                item.Inserted,
                item.Updated
            };
        }

    }
}
