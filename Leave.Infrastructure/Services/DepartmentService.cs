using AutoMapper;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Interfaces;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public Task<ReturnCode> AddAsync(DepartmentDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentDto>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _departmentRepository.Dispose();
        }

        public Task<IEnumerable<DepartmentDto>> FindAllAsync(Expression<Func<DepartmentDto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnCode> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnCode> UpdateAsync(DepartmentDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
