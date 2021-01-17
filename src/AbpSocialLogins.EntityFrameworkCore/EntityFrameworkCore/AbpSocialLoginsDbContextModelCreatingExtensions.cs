using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpSocialLogins.EntityFrameworkCore
{
    public static class AbpSocialLoginsDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpSocialLogins(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpSocialLoginsConsts.DbTablePrefix + "YourEntities", AbpSocialLoginsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}