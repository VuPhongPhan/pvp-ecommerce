using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace pvp_ecommerce.Data;

/* This is used if database provider does't define
 * Ipvp_ecommerceDbSchemaMigrator implementation.
 */
public class Nullpvp_ecommerceDbSchemaMigrator : Ipvp_ecommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
