using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Misc.Ninja.Data;
using Nop.Web.Framework.Infrastructure.Extensions;

namespace Nop.Plugin.Misc.Ninja.Infrastructure
{
    public class PluginDbStartup : INopStartup
    {
        public PluginDbStartup()
        {

        }
        public NinjaCmsObjectContext _context { get; set; }
        public PluginDbStartup(NinjaCmsObjectContext context)
        {
            _context = context;

        }
        public int Order => 1;

        public void Configure(IApplicationBuilder application)
        {
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NinjaCmsObjectContext>(optionsBuilder =>
            optionsBuilder.UseSqlServerWithLazyLoading(services));
        }
    }
}
