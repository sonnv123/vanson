using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;

namespace vanson.Domains.DanhMuc.NewFolder
{
    
  
    [Table("vs_dm_ncc_tinhthanh")]
    [MultiTenancySide(MultiTenancySides.Host)]
    public class DmTinhThanh : FullAuditedEntity
    {
        public string TinhThanh_ma { get; set; }

        public string TinhThanh_ten { get; set; }
        public string TinhThanh_tentat { get; set; }

        public DateTime? TinhThanh_batdau { get; set; }

        public DateTime? TinhThanh_ketthuc { get; set; }

        public int TinhThanh_hieuluc { get; set; }
    }
}
    