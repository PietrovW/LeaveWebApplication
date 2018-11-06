using Leave.DAL.Models.Base;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services.Interfaces
{
    public interface IFurloughService: IService
    {
        Task<ReturnCode> AddAsync(FurloughDto entity);
        Task<IEnumerable<FurloughDto>> AllAsync();
        Task<IEnumerable<FurloughDto>> FindByIdAsync(int id);
        Task<ReturnCode> RemoveAsync(int id);
        Task<ReturnCode> UpdateAsync(FurloughDto entity);
    }
}
