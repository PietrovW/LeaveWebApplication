using Leave.Core.Entitys;
using Leave.DAL.Repositories.Base;
using System;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories.Interfaces
{
    public interface IEmployeRepository : IRepository<EmployeEntity>
    {
        Task<EmployeEntity> GetByIdAsync(int id);
        Task<EmployeEntity> GetByEmailAsync(string email);
    }
}
