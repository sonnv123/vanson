using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;

namespace vanson.Domains.DanhMuc
{
    [Table("vs_dm_ncc_quanhuyen")]
    [MultiTenancySide(MultiTenancySides.Host)]
    public class DmQuanHuyen : FullAuditedEntity
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
