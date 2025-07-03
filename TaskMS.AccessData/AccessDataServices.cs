using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using TaskMS.AccessData.Data;

namespace TaskMS.AccessData
{

    public static class AccessDataServices
    {

        public static IServiceCollection ADServices(this IServiceCollection ServiceCollection, IConfiguration configs)
        {


            ServiceCollection.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configs.GetConnectionString("DevConnstr")));

            return ServiceCollection;
        }

    }
}



