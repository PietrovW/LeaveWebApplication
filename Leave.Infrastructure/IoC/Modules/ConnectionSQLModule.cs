using Autofac;
using Leave.DAL.Context.Base;
using System.Reflection;

namespace Leave.Infrastructure.IoC.Modules
{
    public class ConnectionSQLModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ServiceModule)
               .GetTypeInfo()
               .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                   .Where(x => x.IsAssignableTo<IConnectionFactory>())
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }
    }
}
