using System;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreWebApp.Data;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NetCoreWebApp.Injections
{
    public static class ContextInjection
    {
        public static IServiceCollection AddFakeDbContext(this IServiceCollection services)
        {
            services.AddSingleton<IPersonDbContext, PersonDbContext>();
            return services;
        }
    }
}
