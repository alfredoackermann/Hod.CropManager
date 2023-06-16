using Hod.CropManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Hod.CropManager.Permissions;

public class CropManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CropManagerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CropManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CropManagerResource>(name);
    }
}
