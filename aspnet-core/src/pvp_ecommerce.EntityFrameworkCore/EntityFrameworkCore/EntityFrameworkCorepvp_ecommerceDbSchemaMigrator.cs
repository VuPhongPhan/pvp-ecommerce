using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using pvp_ecommerce.Data;
using Volo.Abp.DependencyInjection;

namespace pvp_ecommerce.EntityFrameworkCore;

public class EntityFrameworkCorepvp_ecommerceDbSchemaMigrator
    : Ipvp_ecommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorepvp_ecommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the pvp_ecommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<pvp_ecommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
