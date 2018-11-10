using AutoMapper;
using Leave.Core.Entitys;
using Leave.Infrastructure.DTO;

namespace Leave.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DepartmentEntity, DepartmentDto>();
                cfg.CreateMap<EmployeEntity, EmployeDto>();
                cfg.CreateMap<EmployeEntity, EmployeDto>();
                cfg.CreateMap<FurloughEntity, FurloughDto>();
                cfg.CreateMap<RecordEntity, RecordDto>();
            })
            .CreateMapper();
    }
}
