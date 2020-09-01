using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Misc.Ninja.Data;
using Nop.Plugin.Misc.Ninja.Domain;
using Nop.Web.Framework.Infrastructure.Extensions;

namespace Nop.Plugin.Misc.Ninja.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 2;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterPluginDataContext<NinjaCmsObjectContext>("nop_object_context_ninjacms");


            //override required repository with our custom context
            builder.RegisterType<EfRepository<NinjaCms>>().As<IRepository<NinjaCms>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_ninjacms"))
                .InstancePerLifetimeScope();
           

        }
    }
}
