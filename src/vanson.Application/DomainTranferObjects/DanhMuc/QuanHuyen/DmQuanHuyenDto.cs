using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace vanson.DomainTranferObjects.DanhMuc.QuanHuyen
{
    public class DmQuanHuyenDto : FullAuditedEntityDto<int?>
    {
        public string QuanHuyen_Ma { get; set; }

        public string QuanHuyen_Ten { get; set; }
        public string QuanHuyen_TenTat { get; set; }

        public string TinhThanh_Ma { get; set; }

        public DateTime? QuanHuyen_BatDau { get; set; }

        public DateTime? QuanHuyen_KetThuc { get; set; }

        public int QuanHuyen_HieuLuc { get; set; }
    }
}
