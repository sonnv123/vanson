using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace vanson.Web.Views
{
    public abstract class vansonRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected vansonRazorPage()
        {
            LocalizationSourceName = vansonConsts.LocalizationSourceName;
        }
    }
}
