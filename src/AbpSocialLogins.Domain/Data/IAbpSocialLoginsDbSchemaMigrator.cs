using System.Threading.Tasks;

namespace AbpSocialLogins.Data
{
    public interface IAbpSocialLoginsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
