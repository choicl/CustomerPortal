using CustomerPortal.Repositories.Abstraction;
using CustomerPortal.Repositories.Implementation;
using CustomerPortal.Services.Interface;
using CustomerPortal.Services.Service;
using CustomerPortal.Web.DataInitial;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerPortal.Web.DI
{
    public static class ServiceConfiguration
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
        

        }

    }
}
