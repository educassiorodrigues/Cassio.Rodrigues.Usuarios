
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Cassio.Rodrigues.Usuarios.Api.DependecyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<Program>());
            return services;
        }
    }
}
