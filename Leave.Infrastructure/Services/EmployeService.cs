using AutoMapper;
using Leave.Core.Entitys;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Interfaces;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using Leave.Infrastructure.Exceptions;

namespace Leave.Infrastructure.Services
{
    public class EmployeService : IEmployeService
    {
        private readonly IEmployeRepository _employeRepository;
        private readonly IEncrypter _encrypter;
        private readonly IMapper _mapper;

        public EmployeService(IEmployeRepository employeRepository, IEncrypter encrypter, IMapper mapper)
        {
            _employeRepository = employeRepository;
            _encrypter = encrypter;
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
           IEnumerable<EmployeEntity> employeEntities= await _employeRepository.AllAsync();

            return _mapper.Map<IEnumerable<EmployeEntity>,IEnumerable<EmployeDto>> (employeEntities);
        }

        public async Task<IEnumerable<EmployeDto>> FindByIdAsync(int id)
        {
            IEnumerable<EmployeEntity> employeEntities = await _employeRepository.FindAllAsync(x=>x.Id==id);

            return _mapper.Map<IEnumerable<EmployeEntity>, IEnumerable<EmployeDto>>(employeEntities);
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

        public async Task<EmployeDto> GetByIdAsync(int id)
        {
            var employeEntities = await _employeRepository.FindAllAsync(x => x.Id == id);
            
            return _mapper.Map<EmployeEntity, EmployeDto>(employeEntities.FirstOrDefault());
        }

        public async Task<EmployeDto> GetByEmailAsync(string email)
        {
            var employeEntities = await _employeRepository.FindAllAsync(x => x.Email == email);

            return _mapper.Map<EmployeEntity, EmployeDto>(employeEntities.FirstOrDefault());
        }

        public async Task LoginAsync(string email, string password)
        {
            var user = await _employeRepository.GetByEmailAsync(email);
            if (user == null)
            {
                throw new ServiceException(ErrorCodes.InvalidCredentials,
                    "Invalid credentials");
            }

            var hash = _encrypter.GetHash(password, user.Salt);
            if (user.Password == hash)
            {
                return;
            }
            throw new ServiceException(ErrorCodes.InvalidCredentials,
                "Invalid credentials");
        }

        public async Task RegisterAsync(Guid userId, string email,
            string username, string password, string role)
        {
            var user = await _employeRepository.GetByEmailAsync(email);
            if (user != null)
            {
                throw new ServiceException(ErrorCodes.EmailInUse,
                    $"User with email: '{email}' already exists.");
            }

            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            user = new EmployeEntity(userId, email, username, role, hash, salt);
            await _employeRepository.AddAsync(user);
        }
    }
}
