using AbpSocialLogins.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSocialLogins.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpSocialLoginsController : AbpController
    {
        protected AbpSocialLoginsController()
        {
            LocalizationResource = typeof(AbpSocialLoginsResource);
        }
    }
}