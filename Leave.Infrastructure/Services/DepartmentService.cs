using AutoMapper;
using Leave.DAL.Repositories.Interfaces;
using Leave.Infrastructure.Services.Interfaces;
using System;

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
        public void Dispose()
        {
            _departmentRepository.Dispose();
        }
    }
}
