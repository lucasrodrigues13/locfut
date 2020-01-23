using LocFut.Application;
using LocFut.Application.Interface;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services.AddScoped<IQuadraService, QuadraService>();
        }
    }
}
