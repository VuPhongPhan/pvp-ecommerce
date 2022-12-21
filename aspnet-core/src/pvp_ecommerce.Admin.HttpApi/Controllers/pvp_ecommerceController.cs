using pvp_ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace pvp_ecommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class pvp_ecommerceController : AbpControllerBase
{
    protected pvp_ecommerceController()
    {
        LocalizationResource = typeof(pvp_ecommerceResource);
    }
}
