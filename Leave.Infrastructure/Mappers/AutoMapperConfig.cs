using AutoMapper;
using Leave.DAL.Models;
using Leave.Infrastructure.DTO;

namespace Leave.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DepartmentModel, DepartmentDto>();
              //  cfg.CreateMap<Driver, DriverDetailsDto>();
                //cfg.CreateMap<Node, NodeDto>();
                //cfg.CreateMap<Route, RouteDto>();
                //cfg.CreateMap<User, UserDto>();
                //cfg.CreateMap<Vehicle, VehicleDto>();
            })
            .CreateMapper();
    }
}
