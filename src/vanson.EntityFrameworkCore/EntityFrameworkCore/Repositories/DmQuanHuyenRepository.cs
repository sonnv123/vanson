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
    public class DmQuanHuyenRepository : vansonRepositoryBase<DmQuanHuyen>
    {
        public DmQuanHuyenRepository(IDbContextProvider<vansonDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
