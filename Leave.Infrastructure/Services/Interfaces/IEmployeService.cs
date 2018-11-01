using Leave.DAL.Models;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Base;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services.Interfaces
{
    public interface IEmployeService : IService
    {
        Task<ReturnCode> AddAsync(EmployeDto entity);
        Task<IEnumerable<EmployeDto>> AllAsync();
        Task<IEnumerable<EmployeDto>> FindAllAsync(Expression<Func<EmployeDto, bool>> predicate);
        Task<EmployeDto> FindAsync(Expression<Func<EmployeDto, bool>> predicate);
        Task<EmployeDto> FindByIDAsync(Guid id);
        Task<ReturnCode> RemoveAsync(Guid id);
        Task<ReturnCode> UpdateAsync(EmployeDto entity);
    }
}
