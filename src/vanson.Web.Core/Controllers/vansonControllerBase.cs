using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace vanson.Controllers
{
    public abstract class vansonControllerBase: AbpController
    {
        protected vansonControllerBase()
        {
            LocalizationSourceName = vansonConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
