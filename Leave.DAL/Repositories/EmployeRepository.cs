using Leave.DAL.Context.Base;
using Leave.Core.Entitys;
using Leave.DAL.Repositories.Base;
using Leave.DAL.Repositories.Interfaces;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Leave.DAL.Repositories
{

    public class EmployeRepository : GenericRepository<EmployeEntity>, IEmployeRepository
    {
        public EmployeRepository(IDbContextBase dbContext, string tableName) : base(dbContext, tableName)
        {

        }

        public async Task<EmployeEntity> GetByEmailAsync(string email)
        {
          var employe = await this.FindAllAsync(x => x.Email == email);
           return employe.SingleOrDefault();
        }

        public async Task<EmployeEntity> GetByIdAsync(int id)
        {
            var employe = await this.FindAllAsync(x => x.Id == id);
            return employe.SingleOrDefault();
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
