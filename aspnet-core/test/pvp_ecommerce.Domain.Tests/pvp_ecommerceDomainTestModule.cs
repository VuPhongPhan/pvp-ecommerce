using pvp_ecommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace pvp_ecommerce;

[DependsOn(
    typeof(pvp_ecommerceEntityFrameworkCoreTestModule)
    )]
public class pvp_ecommerceDomainTestModule : AbpModule
{

}
