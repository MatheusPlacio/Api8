using Data.Context;
using Data.Repository;
using Domain.Interfaces.IRepository;
using Domain.Interfaces.IService;
using Service.Service;

namespace Api8.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<MyContext>();

            //Repository
            services.AddScoped<IClienteRepository, ClienteRepository>();

            //Service
            services.AddScoped<IClienteService, ClienteService>();

            services.AddHttpClient();
        }
    }
}
