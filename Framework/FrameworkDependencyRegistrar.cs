using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Nextech.Domain;

namespace Nextech.Framework
{
    public class FrameworkDependencyRegistrar:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HackerNewsService>().As<IHackerNewsService>();
            base.Load(builder);
        }
    }
}
