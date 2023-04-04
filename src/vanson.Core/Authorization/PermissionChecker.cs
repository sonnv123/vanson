using Abp.Authorization;
using vanson.Authorization.Roles;
using vanson.Authorization.Users;

namespace vanson.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
