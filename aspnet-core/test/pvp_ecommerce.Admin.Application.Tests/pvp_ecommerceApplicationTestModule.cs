using Volo.Abp.Modularity;

namespace pvp_ecommerce.Admin;

[DependsOn(
    typeof(pvp_ecommerceApplicationModule),
    typeof(pvp_ecommerceDomainTestModule)
    )]
public class pvp_ecommerceApplicationTestModule : AbpModule
{

}
