using System;
using System.Collections.Generic;
using System.Text;
using AbpSocialLogins.Localization;
using Volo.Abp.Application.Services;

namespace AbpSocialLogins
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpSocialLoginsAppService : ApplicationService
    {
        protected AbpSocialLoginsAppService()
        {
            LocalizationResource = typeof(AbpSocialLoginsResource);
        }
    }
}
