using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace pvp_ecommerce;

[Dependency(ReplaceServices = true)]
public class pvp_ecommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "pvp_ecommerce";
}
