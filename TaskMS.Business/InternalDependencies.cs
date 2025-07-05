using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMS.Business.Services;
using TaskMS.Business.ServicesConstracts;

namespace TaskMS.Business
{
    public static class InternalDependencies
    {
        public static IServiceCollection BusinessInternalServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskService, TaskService>();




            return services;
        }
    }
}
