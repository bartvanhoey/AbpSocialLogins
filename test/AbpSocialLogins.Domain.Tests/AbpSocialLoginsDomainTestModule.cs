using AbpSocialLogins.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpSocialLogins
{
    [DependsOn(
        typeof(AbpSocialLoginsEntityFrameworkCoreTestModule)
        )]
    public class AbpSocialLoginsDomainTestModule : AbpModule
    {

    }
}