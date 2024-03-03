using Avadone_ia.Application.Common.Interfaces.Persistence;
using Avadone_ia.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Avadone_ia.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ITodoRepository, TodoRepository>();

        return services;
    }
}