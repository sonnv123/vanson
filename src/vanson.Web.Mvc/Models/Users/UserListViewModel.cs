using System.Collections.Generic;
using vanson.Roles.Dto;

namespace vanson.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
