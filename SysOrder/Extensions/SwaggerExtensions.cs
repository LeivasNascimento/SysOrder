using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.IO;

namespace SysOrder.Api.Extensions
{
    public static class SwaggerExtensions
    {
        public static void SwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Litios Dev",
                    Description = "API de pedidos",
                    TermsOfService = new Uri("https://example.com/terms")
                });

                var xmlApiPath = Path.Combine(AppContext.BaseDirectory, $"{typeof(Startup).Assembly.GetName().Name.Replace("Sys","")}.xml");

                c.IncludeXmlComments(xmlApiPath);
            });
        }
    }
}
