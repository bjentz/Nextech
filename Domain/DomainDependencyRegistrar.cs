using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Nextech.Domain
{
    public class DomainDependencyRegistrar:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Article>();
            base.Load(builder);
        }
    }
}
