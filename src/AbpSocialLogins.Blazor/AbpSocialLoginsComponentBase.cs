using AbpSocialLogins.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpSocialLogins.Blazor
{
    public abstract class AbpSocialLoginsComponentBase : AbpComponentBase
    {
        protected AbpSocialLoginsComponentBase()
        {
            LocalizationResource = typeof(AbpSocialLoginsResource);
        }
    }
}
