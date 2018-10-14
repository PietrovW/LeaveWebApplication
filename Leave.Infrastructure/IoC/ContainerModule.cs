using Autofac;
using AutoMapper.Configuration;
using Leave.Infrastructure.IoC.Modules;
using Leave.Infrastructure.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.Infrastructure.IoC
{
    public class ContainerModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterInstance(AutoMapperConfig.Initialize())
                .SingleInstance();
            builder.RegisterModule<CommandModule>();
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServiceModule>();
            /*
            builder.RegisterModule<CommandModule>();
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<MongoModule>();
            builder.RegisterModule<SqlModule>();
            
            builder.RegisterModule(new SettingsModule(_configuration));
    */
        }
    }
}
