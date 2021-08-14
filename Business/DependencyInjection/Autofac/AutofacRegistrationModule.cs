using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Business.DependencyInjection.Autofac
{
    public class AutofacRegistrationModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
