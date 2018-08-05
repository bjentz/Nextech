using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Autofac;
using Nextech.Domain;

namespace Nextech.Data
{
    public class DataDependencyRegistrar:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HackerNewsRepository>().As<IHakerNewsRepository<Article>>();
            builder.RegisterType<HttpClient>();
            base.Load(builder);
        }
    }
}
