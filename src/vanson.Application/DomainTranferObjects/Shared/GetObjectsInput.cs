using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace vanson.DomainTranferObjects.Shared
{
    internal class GetObjectsInput : PagedResultRequestDto
    {
        public string Filter { get; set; }

        public string Key { get; set; }
    }
}
