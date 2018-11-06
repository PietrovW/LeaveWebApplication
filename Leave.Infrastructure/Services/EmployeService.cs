using AutoMapper;
using Leave.DAL.Entitys;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Interfaces;
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
        private readonly IEmployeRepository _employeRepository;
        private readonly IMapper _mapper;

        public EmployeService(IEmployeRepository employeRepository, IMapper mapper)
        {
            _employeRepository = employeRepository;
            _mapper = mapper;
        }

        public async Task<ReturnCode> AddAsync(EmployeDto entity)
        {
            var employeEntity = _mapper.Map<EmployeDto, EmployeEntity> (entity);
            var employ =await _employeRepository.AddAsync(employeEntity);

            return employ.Item1;
        }

        public async Task<IEnumerable<EmployeDto>> AllAsync()
        {
            Tuple<ReturnCode,IEnumerable<EmployeEntity>> employeEntities= await _employeRepository.AllAsync();

            return _mapper.Map<IEnumerable<EmployeEntity>,IEnumerable<EmployeDto>> (employeEntities.Item2);
        }

        public async Task<IEnumerable<EmployeDto>> FindByIdAsync(int id)
        {
            Tuple<ReturnCode, IEnumerable<EmployeEntity>> employeEntities = await _employeRepository.FindAllAsync(x=>x.Id==id);

            return _mapper.Map<IEnumerable<EmployeEntity>, IEnumerable<EmployeDto>>(employeEntities.Item2);
        }

        public async Task<ReturnCode> RemoveAsync(int id)
        {
            return await _employeRepository.RemoveAsync(id);
        }

        public async Task<ReturnCode> UpdateAsync(EmployeDto entity)
        {
            var employeEntity = _mapper.Map<EmployeDto, EmployeEntity>(entity);
            var employ = await _employeRepository.UpdateAsync(employeEntity);

            return employ;
        }

        public void Dispose()
        {
            _employeRepository.Dispose();
        }
    }
}
