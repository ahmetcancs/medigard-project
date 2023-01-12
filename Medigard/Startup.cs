using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using Medigard.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard
{
    public class Startup
    {

        public const string DEFAULT_WITHOUT_LANGUAGE_PREFIX_ROUTE_NAME = "DefaultWithoutLanguagePrefix";
        public const string CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS = "Home|Detail";

        public IWebHostEnvironment Environment { get; }
        

        public Startup(IWebHostEnvironment environment)
        {
            
            Environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var kenticoServiceCollection = services.AddKentico(features =>
            {
                features.UsePageBuilder();
                // features.UseActivityTracking();
                // features.UseABTesting();
                // features.UseWebAnalytics();
                // features.UseEmailTracking();
                // features.UseCampaignLogger();
                // features.UseScheduler();
                features.UsePageRouting();
            });

            if (Environment.IsDevelopment())
            {
                // By default, Xperience sends cookies using SameSite=Lax. If the administration and live site applications
                // are hosted on separate domains, this ensures cookies are set with SameSite=None and Secure. The configuration
                // only applies when communicating with the Xperience administration via preview links. Both applications also need
                // to use a secure connection (HTTPS) to ensure cookies are not rejected by the client.
                kenticoServiceCollection.SetAdminCookiesSameSiteNone();

                // By default, Xperience requires a secure connection (HTTPS) if administration and live site applications
                // are hosted on separate domains. This configuration simplifies the initial setup of the development
                // or evaluation environment without the need for secure connection. The system ignores authentication
                // cookies and this information is taken from the URL.
                kenticoServiceCollection.DisableVirtualContextSecurityForLocalhost();
            }
            services.AddMedigardServices();

            services.AddAuthentication();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseStaticFiles();

            app.UseKentico();

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                //endpoints.Kentico().MapRoutes();
                // endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();

                //endpoints.MapControllerRoute(
                //   name: "default",
                //   pattern: $"{{culture}}/{{controller}}/{{action}}",
                //   constraints: new
                //   {
                //       culture = new SiteCultureConstraint { HideLanguagePrefixForDefaultCulture = true },
                //       controller = CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS
                //   }

                //);
                //endpoints.MapControllerRoute(
                //    name: DEFAULT_WITHOUT_LANGUAGE_PREFIX_ROUTE_NAME,
                //    pattern: "{controller}/{action}",
                //    constraints: new
                //    {
                //        controller = CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS
                //    }

                //);

            });

        }
    }
}
