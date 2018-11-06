using Leave.DAL.Models;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Base;
using Leave.Infrastructure.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services.Interfaces
{
    public interface IDepartmentService : IService
    {
        Task<ReturnCode> AddAsync(DTO.DepartmentDto entity);
        Task<IEnumerable<DTO.DepartmentDto>> AllAsync();
        Task<IEnumerable<DTO.DepartmentDto>> FindByIdAsync(int id);
        Task<ReturnCode> RemoveAsync(int id);
        Task<ReturnCode> UpdateAsync(DTO.DepartmentDto entity);
    }
}
