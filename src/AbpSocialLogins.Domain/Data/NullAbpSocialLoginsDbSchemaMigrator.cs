using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpSocialLogins.Data
{
    /* This is used if database provider does't define
     * IAbpSocialLoginsDbSchemaMigrator implementation.
     */
    public class NullAbpSocialLoginsDbSchemaMigrator : IAbpSocialLoginsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}