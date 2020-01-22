using LocFut.Data.Context;
using LocFut.Data.Interface;
using LocFut.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DataExtensions
    {
        public static IServiceCollection AddInfraData(this IServiceCollection services)
        {
            return services.AddScoped<DbContextLocFut>().AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>))
                .AddScoped<IQuadraRepository, QuadraRepository>();
        }
    }
}
