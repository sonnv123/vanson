using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vanson.AppServices.DanhMuc;
using vanson.Controllers;
using vanson.Domains.DanhMuc;
using vanson.MultiTenancy.Dto;
using System;

namespace vanson.Web.Controllers
{
    public class QuanHuyenController : vansonControllerBase
    {
        private readonly DmQuanHuyenAppService _dmQuanHuyenAppService;

        public QuanHuyenController(DmQuanHuyenAppService dmQuanHuyenAppService)
        {
            _dmQuanHuyenAppService = dmQuanHuyenAppService;
        }

        public ActionResult Index() => View();

        public async Task<ActionResult> EditModal(int tenantId)
        {
            try
            {
                var kk = PartialView("_EditModal", new TenantDto());
                return kk;

            }
            catch(Exception ex)
            {
                return null;

            }
        }
    }
}
