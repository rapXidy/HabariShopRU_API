using HabariShopRU.API.DataAccess.DbServices;
using HabariShopRU.API.DataAccess.IDbServices;

namespace HabariShopRU.API.BusinessLogic.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDbAccessService, DbAccessService>();

            return services;
        }
    }
}

