using Microsoft.Extensions.DependencyInjection;
using Order.Application.Applications;
using Order.Application.Interfacds;
using Order.Application.Interfacds.Security;
using Order.Application.Interfaces;
using Order.Application.Security;
using Order.Domain.Common;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Services;
using Order.Infra.Repositories;

namespace SysOrder.Api.Extensions
{
    public static class RegisterIoCExtensions //IoC = Inversion Of Control
    {
        public static void RegisterIoC(this IServiceCollection services) // o this extende a classe para que seja parte do services e assim
            //na inversão de controle esta classe passa a ter algo a mais
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGenerators, Generators>();
            services.AddScoped<ITimeProvider, TimeProvider>();

            services.AddScoped<IClientApplication, ClientApplication>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRepository>();

            services.AddScoped<IOrderApplication, OrderApplication>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<IProductApplication, ProductApplication>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUserApplication, UserApplication>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

          
            services.AddScoped<ISecurityService, SecurityService>();

            services.AddScoped<ITokenManager, TokenManager>();


        }
    }
}
