using Commify.IncomeTaxCalculator.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Commify.IncomeTaxCalculator.Permissions;

public class IncomeTaxCalculatorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(IncomeTaxCalculatorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(IncomeTaxCalculatorPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<IncomeTaxCalculatorResource>(name);
    }
}
