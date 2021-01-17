using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpSocialLogins.Data;
using Volo.Abp.DependencyInjection;

namespace AbpSocialLogins.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpSocialLoginsDbSchemaMigrator
        : IAbpSocialLoginsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpSocialLoginsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpSocialLoginsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpSocialLoginsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}