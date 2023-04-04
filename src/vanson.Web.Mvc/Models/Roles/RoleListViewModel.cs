using System.Collections.Generic;
using vanson.Roles.Dto;

namespace vanson.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
