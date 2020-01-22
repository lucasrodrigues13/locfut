using LocFut.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace LocFut.Application.Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services.AddScoped<IQuadraService, QuadraService>();
        }
    }
}
