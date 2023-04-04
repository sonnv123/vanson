using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using vanson.Controllers;

namespace vanson.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : vansonControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
