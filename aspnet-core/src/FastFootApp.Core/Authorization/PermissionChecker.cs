using Abp.Authorization;
using FastFootApp.Authorization.Roles;
using FastFootApp.Authorization.Users;

namespace FastFootApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
