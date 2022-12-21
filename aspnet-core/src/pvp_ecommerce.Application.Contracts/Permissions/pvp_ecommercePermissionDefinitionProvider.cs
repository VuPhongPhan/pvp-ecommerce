using pvp_ecommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace pvp_ecommerce.Permissions;

public class pvp_ecommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(pvp_ecommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(pvp_ecommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<pvp_ecommerceResource>(name);
    }
}
