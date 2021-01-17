using Volo.Abp.Bundling;

namespace AbpSocialLogins.Blazor
{
    public class AbpSocialLoginsBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}