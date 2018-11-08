using AutoMapper;
using Leave.Core.Domain.Entitys;
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

        public async Task<ReturnCode> AddAsync(DepartmentDto entity)
        {
            var departmentEntity = _mapper.Map<DepartmentDto, DepartmentEntity>(entity);
            var employ = await _departmentRepository.AddAsync(departmentEntity);

            return employ.Item1;
        }

        public async Task<IEnumerable<DepartmentDto>> AllAsync()
        {
            Tuple<ReturnCode, IEnumerable<DepartmentEntity>> departmentEntities = await _departmentRepository.AllAsync();

            return _mapper.Map<IEnumerable<DepartmentEntity>, IEnumerable<DepartmentDto>>(departmentEntities.Item2);
        }

       
        public async Task<IEnumerable<DepartmentDto>> FindByIdAsync(int id)
        {
            
            Tuple<ReturnCode, IEnumerable<DepartmentEntity>> departmentEntities = await _departmentRepository.FindAllAsync(x=>x.Id==id);

            return _mapper.Map<IEnumerable<DepartmentEntity>, IEnumerable<DepartmentDto>>(departmentEntities.Item2);
        }

        public async Task<ReturnCode> RemoveAsync(int id)
        {
            return await _departmentRepository.RemoveAsync(id);
        }

        public async Task<ReturnCode> UpdateAsync(DepartmentDto entity)
        {
            var departmentEntities = _mapper.Map<DepartmentDto, DepartmentEntity>(entity);
            var department = await _departmentRepository.UpdateAsync(departmentEntities);

            return department;
        }

        public void Dispose()
        {
            _departmentRepository.Dispose();
        }

    }
}
