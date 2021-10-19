using System.Collections.Generic;
using System.Reflection;
using Autofac;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using DataAccess;
using DataAccess.Concrete.AutoMapper;
using Module = Autofac.Module;

namespace Business.DependencyInjection.Autofac
{
    public class AutofacRegistrationModule: Module
    {
    
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(
                    c => new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile(new AutoMapperConfigurations());
                    }))
                .AsSelf()
                .SingleInstance();

            builder.Register(
                    c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AutoMapperConfigurations>().AsSelf();

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<NorthwindDbContext>();
      

        }

    }
}
