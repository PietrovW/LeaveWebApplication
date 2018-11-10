using Leave.DAL.Models.Base;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services.Interfaces
{
    public interface IEmployeService : IService
    {
        Task<ReturnCode> AddAsync(EmployeDto entity);
        Task<IEnumerable<EmployeDto>> AllAsync();
        Task<IEnumerable<EmployeDto>> FindByIdAsync(int id);
        Task<ReturnCode> RemoveAsync(int id);
        Task<ReturnCode> UpdateAsync(EmployeDto entity);
        Task<EmployeDto> GetByIdAsync(int id);
        Task<EmployeDto> GetByEmailAsync(string email);
    }
}
