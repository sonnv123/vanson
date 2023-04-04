using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using vanson.Domains.DanhMuc;
using vanson.Domains.DanhMuc.NewFolder;

namespace vanson.EntityFrameworkCore.Repositories
{
    public class DmTinhThanh22repository : vansonRepositoryBase<DmTinhThanh>
    {
        public DmTinhThanh22repository(IDbContextProvider<vansonDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
 
