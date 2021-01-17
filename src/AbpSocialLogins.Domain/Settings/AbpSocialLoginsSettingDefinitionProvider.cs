using Volo.Abp.Settings;

namespace AbpSocialLogins.Settings
{
    public class AbpSocialLoginsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpSocialLoginsSettings.MySetting1));
        }
    }
}
