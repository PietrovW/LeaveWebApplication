using Leave.DAL.Models.Base;
using Leave.Infrastructure.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services.Interfaces
{
    public interface IRecordService : IService
    {
        Task<ReturnCode> AddAsync(DTO.RecordDto entity);
        Task<IEnumerable<DTO.RecordDto>> AllAsync();
        Task<IEnumerable<DTO.RecordDto>> FindByIdAsync(int id);
        Task<ReturnCode> RemoveAsync(int id);
        Task<ReturnCode> UpdateAsync(DTO.RecordDto entity);
    }
}
