using Medigard.Repositories.Detail;
using Medigard.Repositories.Home;
using Medigard.Repositories.Menu;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Helpers
{
    public static class IServiceCollectionExtensions
    {
        public static void AddMedigardServices(this IServiceCollection services)
        {

            AddRepositories(services);


        }
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddSingleton<HomeRepository>();
            services.AddSingleton<DetailRepository>();
            services.AddSingleton<MenuRepository>();

        }
         
    }
}
