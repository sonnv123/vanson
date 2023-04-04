using Microsoft.AspNetCore.Mvc;
using vanson.AppServices.DanhMuc;
using vanson.Controllers;

namespace vanson.Web.Controllers
{
    public class TinhThanhController : vansonControllerBase
    {
        private readonly DmTinhThanhAppService _dmTinhThanhAppService;

        public TinhThanhController(DmTinhThanhAppService dmTinhThanhAppService)
        {
            _dmTinhThanhAppService = dmTinhThanhAppService;
        }

        public ActionResult Index() => View();
    }
}

