using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using vanson.Domains.DanhMuc;
using vanson.Domains.DanhMuc.NewFolder;
using vanson.DomainTranferObjects.DanhMuc.QuanHuyen;
using vanson.DomainTranferObjects.Shared;
using vanson.EntityFrameworkCore.Repositories;
using vanson.MultiTenancy.Dto;
using vanson.Roles.Dto;

namespace vanson.AppServices.DanhMuc
{
    public class DmTinhThanhAppService : vansonAppServiceBase
    {
        private readonly DmTinhThanh22repository _dmttRepository;
        public DmTinhThanhAppService(DmTinhThanh22repository dmttRepository
                    ) => _dmttRepository = dmttRepository;

        //public async Task<PagedResultDto<DmQuanHuyenDto>> GetDmQuanHuyen(GetObjectsInput input)
        //{
        //    var query = _dmquanhuyenRepository.GetAll()
        //    .WhereIf(!string.IsNullOrEmpty(input.Filter),
        //    p => p.QuanHuyen_Ma.ToLower().Contains(input.Filter.ToLower().Trim()) ||
        //    p.QuanHuyen_Ten.ToLower().Contains(input.Filter.ToLower().Trim()));

        //    var dmquanhuyenCount = await query.CountAsync();

        //    var dmquanhuyens = await query
        //        .OrderByDescending(p => p.CreationTime)
        //        .PageBy(input)
        //        .ToListAsync();

        //    var dmquanhuyenListDtos = ObjectMapper.Map<List<DmQuanHuyenDto>>(query);

        //    return new PagedResultDto<DmQuanHuyenDto>(
        //        dmquanhuyenCount,
        //        dmquanhuyenListDtos
        //        );
        //}

        public List<DmTinhThanh> GetDmTinhThanhTest()
        {
            var lst = _dmttRepository.GetAll().ToList();
            return lst;
        }
        public Result GetAll(PagedTenantResultRequestDto input)
        {
            var lst = _dmttRepository.GetAll();
            var total = lst.Count();
            lst = lst.Skip(input.SkipCount).Take(input.MaxResultCount);
            return new Result
            {
                items = lst.ToList(),
                totalCount = total
            };
        }

    }
    public class Result
    {
        public int totalCount { get; set; }
        public List<DmTinhThanh> items { get; set; }
    }
}
//        public List<DmTinhThanh> GetAll()
//        {
//            var lst = _dmttRepository.GetAll().ToList();
//            return lst;
//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Abp.Application.Services.Dto;
//using Abp.Linq.Extensions;
//using Microsoft.EntityFrameworkCore;
//using vanson.Domains.DanhMuc;
//using vanson.Domains.DanhMuc.NewFolder;
//using vanson.DomainTranferObjects.DanhMuc.QuanHuyen;
//using vanson.DomainTranferObjects.Shared;
//using vanson.EntityFrameworkCore.Repositories;
//using vanson.MultiTenancy.Dto;
//using vanson.Roles.Dto;

//namespace vanson.AppServices.DanhMuc
//{
//    public class DmQuanHuyenAppService : vansonAppServiceBase
//    {
//        private readonly DmQuanHuyenRepository _dmqhRepository;
//        public DmQuanHuyenAppService(DmQuanHuyenRepository dmqhRepository
//                    ) => _dmqhRepository = dmqhRepository;

//        //public async Task<PagedResultDto<DmQuanHuyenDto>> GetDmQuanHuyen(GetObjectsInput input)
//        //{
//        //    var query = _dmquanhuyenRepository.GetAll()
//        //    .WhereIf(!string.IsNullOrEmpty(input.Filter),
//        //    p => p.QuanHuyen_Ma.ToLower().Contains(input.Filter.ToLower().Trim()) ||
//        //    p.QuanHuyen_Ten.ToLower().Contains(input.Filter.ToLower().Trim()));

//        //    var dmquanhuyenCount = await query.CountAsync();

//        //    var dmquanhuyens = await query
//        //        .OrderByDescending(p => p.CreationTime)
//        //        .PageBy(input)
//        //        .ToListAsync();

//        //    var dmquanhuyenListDtos = ObjectMapper.Map<List<DmQuanHuyenDto>>(query);

//        //    return new PagedResultDto<DmQuanHuyenDto>(
//        //        dmquanhuyenCount,
//        //        dmquanhuyenListDtos
//        //        );
//        //}

//        public List<DmQuanHuyen> GetDmQuanHuyenTest()
//        {
//            var lst = _dmqhRepository.GetAll().ToList();
//            return lst;
//        }
//        public Result GetAll(PagedTenantResultRequestDto input)
//        {
//            var lst = _dmqhRepository.GetAll();
//            var total = lst.Count();
//            lst = lst.Skip(input.SkipCount).Take(input.MaxResultCount);
//            return new Result
//            {
//                items = lst.ToList(),
//                totalCount = total
//            };
//        }

//    }
//    public class Result
//    {
//        public int totalCount { get; set; }
//        public List<DmQuanHuyen> items { get; set; }
//    }
//}