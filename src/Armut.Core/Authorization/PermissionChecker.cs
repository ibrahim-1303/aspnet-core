using Abp.Authorization;
using Armut.Authorization.Roles;
using Armut.Authorization.Users;

namespace Armut.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
