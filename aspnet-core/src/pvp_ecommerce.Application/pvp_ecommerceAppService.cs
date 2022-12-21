using System;
using System.Collections.Generic;
using System.Text;
using pvp_ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace pvp_ecommerce;

/* Inherit your application services from this class.
 */
public abstract class pvp_ecommerceAppService : ApplicationService
{
    protected pvp_ecommerceAppService()
    {
        LocalizationResource = typeof(pvp_ecommerceResource);
    }
}
