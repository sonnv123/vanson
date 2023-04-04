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
    public class DmQuanHuyenAppService : vansonAppServiceBase
    {
        private readonly DmQuanHuyenRepository _dmqhRepository;
        public DmQuanHuyenAppService(DmQuanHuyenRepository dmqhRepository
                    ) => _dmqhRepository = dmqhRepository;

         public List<DmQuanHuyen> GetDmQuanHuyenTest()
        {
            var lst = _dmqhRepository.GetAll().ToList();
            return lst;
        }
        public ResultQH GetAll(PagedTenantResultRequestDto input)
        {
            var lst = _dmqhRepository.GetAll();
            var total = lst.Count();
            lst = lst.Skip(input.SkipCount).Take(input.MaxResultCount);
            return new ResultQH
            {
                items = lst.ToList(),
                totalCount = total
            };
        }

        public Task GetAsync(EntityDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
    public class ResultQH
    {
        public int totalCount { get; set; }
        public List<DmQuanHuyen> items { get; set; }
    }
}
