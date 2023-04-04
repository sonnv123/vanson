using Abp.AspNetCore.Mvc.ViewComponents;

namespace vanson.Web.Views
{
    public abstract class vansonViewComponent : AbpViewComponent
    {
        protected vansonViewComponent()
        {
            LocalizationSourceName = vansonConsts.LocalizationSourceName;
        }
    }
}
