using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSocialLogins.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpSocialLoginsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpSocialLogins";
    }
}
