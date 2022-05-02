using Microsoft.Extensions.DependencyInjection;
using Order.Application.Applications;
using Order.Application.Interfaces;
using Order.Domain.Common;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Services;
using Order.Infra.Repositories;

namespace SysOrder.Api.Extensions
{
    public static class RegisterIoCExtensions
    {
        public static void RegisterIoC(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClientApplication, ClientApplication>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRepository>();

            services.AddScoped<ITimeProvider, TimeProvider>();
            services.AddScoped<IGenerators, Generators>();

        }
    }
}
