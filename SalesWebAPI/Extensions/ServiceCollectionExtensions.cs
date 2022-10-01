using SalesWebAPI.Data;
using SalesWebAPI.Models;

namespace SalesWebAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddSalesWebAPIServices(this IServiceCollection services)
    {
        services.AddTransient<IDataManager<Buyer>, DataManager<Buyer>>();
    }
}
