using pvp_ecommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace pvp_ecommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(pvp_ecommerceEntityFrameworkCoreModule),
    typeof(pvp_ecommerceApplicationContractsModule)
    )]
public class pvp_ecommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
