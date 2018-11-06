using Autofac;
using Leave.DAL.Context;
using Leave.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;

namespace Leave.Infrastructure.IoC.Modules
{
    public class SettingsModule : Autofac.Module
    {

        private readonly IConfiguration _configuration;
        public SettingsModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(_configuration.GetSettings<SqlSettings>())
                   .SingleInstance();
        }
    }
}
