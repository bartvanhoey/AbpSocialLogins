using Volo.Abp.Modularity;

namespace AbpSocialLogins
{
    [DependsOn(
        typeof(AbpSocialLoginsApplicationModule),
        typeof(AbpSocialLoginsDomainTestModule)
        )]
    public class AbpSocialLoginsApplicationTestModule : AbpModule
    {

    }
}