using AutoMapper;
using Leave.Core.Entitys;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Interfaces;
using Leave.Infrastructure.DTO;
using Leave.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IMapper _mapper;

        public RecordService(IRecordRepository recordRepository, IMapper mapper)
        {
            _recordRepository = recordRepository;
            _mapper = mapper;
        }

        public async Task<ReturnCode> AddAsync(RecordDto entity)
        {
            var recordEntity = _mapper.Map<RecordDto, RecordEntity>(entity);
            var employ = await _recordRepository.AddAsync(recordEntity);

            return employ.Item1;
        }

        public async Task<IEnumerable<RecordDto>> AllAsync()
        {
            IEnumerable<RecordEntity> recordEntities = await _recordRepository.AllAsync();

            return _mapper.Map<IEnumerable<RecordEntity>, IEnumerable<RecordDto>>(recordEntities);
        }

        public async Task<IEnumerable<RecordDto>> FindByIdAsync(int id)
        {
           IEnumerable<RecordEntity> recordEntities = await _recordRepository.FindAllAsync(x=>x.Id==id);

            return _mapper.Map<IEnumerable<RecordEntity>, IEnumerable<RecordDto>>(recordEntities);
        }

        public async Task<ReturnCode> RemoveAsync(int id)
        {
            return await _recordRepository.RemoveAsync(id);
        }

        public async Task<ReturnCode> UpdateAsync(RecordDto entity)
        {
            var recordEntity = _mapper.Map<RecordDto, RecordEntity>(entity);
            var record = await _recordRepository.UpdateAsync(recordEntity);

            return record;
        }

        public void Dispose()
        {
            _recordRepository.Dispose();
        }
    }
}
