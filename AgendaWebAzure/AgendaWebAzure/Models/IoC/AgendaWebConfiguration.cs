using AgendaWebAzure.Models.Infrastructure.Repositories;
using AgendaWebAzure.Models.Services;

namespace AgendaWebAzure.Models.IoC
{
    public class AgendaWebConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
        }
    }
}
