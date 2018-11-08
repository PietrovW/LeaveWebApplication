using AutoMapper;
using Leave.Core.Domain.Entitys;
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
    public class FurloughService : IFurloughService
    {
        private readonly IFurloughRepository _furloughRepository;
        private readonly IMapper _mapper;

        public FurloughService(IFurloughRepository furloughRepository, IMapper mapper)
        {
            _furloughRepository = furloughRepository;
            _mapper = mapper;
        }

        public async Task<ReturnCode> AddAsync(FurloughDto entity)
        {
            var furloughEntity = _mapper.Map<FurloughDto, FurloughEntity>(entity);
            var employ = await _furloughRepository.AddAsync(furloughEntity);

            return employ.Item1;
        }

        public async Task<IEnumerable<FurloughDto>> AllAsync()
        {
            Tuple<ReturnCode, IEnumerable<FurloughEntity>> furloughEntities = await _furloughRepository.AllAsync();

            return _mapper.Map<IEnumerable<FurloughEntity>, IEnumerable<FurloughDto>>(furloughEntities.Item2);
        }

        public async Task<IEnumerable<FurloughDto>> FindByIdAsync(int id)
        {
            Tuple<ReturnCode, IEnumerable<FurloughEntity>> furloughEntities = await _furloughRepository.FindAllAsync(x=>x.Id==id);

            return _mapper.Map<IEnumerable<FurloughEntity>, IEnumerable<FurloughDto>>(furloughEntities.Item2);
        }

        public async Task<ReturnCode> RemoveAsync(int id)
        {
            return await _furloughRepository.RemoveAsync(id);
        }

        public async Task<ReturnCode> UpdateAsync(FurloughDto entity)
        {
            var furloughEntity = _mapper.Map<FurloughDto, FurloughEntity>(entity);
            var furlough = await _furloughRepository.UpdateAsync(furloughEntity);

            return furlough;
        }

        public void Dispose()
        {
            _furloughRepository.Dispose();
        }
    }
}
