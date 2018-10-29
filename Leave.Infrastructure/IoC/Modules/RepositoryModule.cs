using Autofac;
using Leave.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Leave.Infrastructure.IoC.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(RepositoryModule)
                .GetTypeInfo()
                .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                   .Where(x => x.Name.EndsWith("Repository"))
                   .AsClosedTypesOf(typeof(IRepository<>))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }
    }
}
