using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace IdSrv
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityServer(options => { options.IssuerUri = "https://idsv.weatherportal"; })
                .AddDeveloperSigningCredential()
                .AddInMemoryClients(IdStore.Clients)
                .AddInMemoryApiResources(IdStore.ApiResources);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("You have reached the IdSrv, nothing here to view.");
            });
        }
    }
}
