using AbpSocialLogins.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpSocialLogins.Permissions
{
    public class AbpSocialLoginsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpSocialLoginsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpSocialLoginsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpSocialLoginsResource>(name);
        }
    }
}
