using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
namespace Catalog;

public  static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services,
     IConfiguration configuration)
    {
        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app){
        // app
        //     .UseApplicationServices()
        //     .UseInfrastructureServices()
        //     .UseApiServices();
        return app;
    }
}
