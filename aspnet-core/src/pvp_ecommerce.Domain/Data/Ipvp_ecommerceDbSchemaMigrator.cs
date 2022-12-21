using System.Threading.Tasks;

namespace pvp_ecommerce.Data;

public interface Ipvp_ecommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
