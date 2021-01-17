using AbpSocialLogins.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpSocialLogins.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpSocialLoginsEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpSocialLoginsApplicationContractsModule)
        )]
    public class AbpSocialLoginsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
