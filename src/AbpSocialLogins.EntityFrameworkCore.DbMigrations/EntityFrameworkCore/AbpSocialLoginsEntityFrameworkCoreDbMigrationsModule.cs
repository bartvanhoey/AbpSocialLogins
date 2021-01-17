using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpSocialLogins.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpSocialLoginsEntityFrameworkCoreModule)
        )]
    public class AbpSocialLoginsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpSocialLoginsMigrationsDbContext>();
        }
    }
}
