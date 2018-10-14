using Leave.DAL.Models.Base;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services
{
    public class EmployeService : IEmployeService
    {
        public Task<ResultCode> AddAsync(EmployeDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeDto>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeDto>> FindAllAsync(Expression<Func<EmployeDto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeDto> FindAsync(Expression<Func<EmployeDto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeDto> FindByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> UpdateAsync(EmployeDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
